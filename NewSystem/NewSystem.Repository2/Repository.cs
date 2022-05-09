using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NewSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace NewSystem.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _dbcontext;

        private DbSet<T> DbSet
        {
            get { return _dbcontext.Set<T>(); }
        }

        public Repository(DbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public DbContext GetContext()
        {
            return _dbcontext;
        }

        public string Insert(T entity)
        {
            DbSet.Add(entity);
            return this.SaveChanges();
        }

        public string Update(T entity)
        {
            if (_dbcontext.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);
            _dbcontext.Entry<T>(entity).State = EntityState.Modified;
            return this.SaveChanges();
        }

        public string Delete(T entity)
        {
            if (_dbcontext.Entry(entity).State == EntityState.Detached)
                DbSet.Attach(entity);
            DbSet.Remove(entity);
            return this.SaveChanges();
        }

        public string Delete(int id)
        {
            T entity = DbSet.Find(id);
            if (entity != null)
            {
                DbSet.Remove(entity);
                return this.SaveChanges();
            }
            else
                return "";
        }

        public void Cancel(T entity)
        {
            //dbContext.Entry<T>(entity).Reload();
        }

        public IQueryable<T> Filter(string condition)
        {
            //return DbSet.Where(condition);
            return null;
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public IQueryable<T> GetTop(int n)
        {
            return DbSet.Take(n);
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public int GetCount()
        {
            return DbSet.Count();
        }

        public string DeleteRange(List<T> entities)
        {
            DbSet.RemoveRange(entities);
            return this.SaveChanges();
        }

        public string SaveChanges()
        {
            var entities = from e in _dbcontext.ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext);
            }

            try
            {
                _dbcontext.SaveChanges();
                return "";
            }            
            catch (Exception erro)
            {
                if (erro.InnerException != null)
                {
                    if (erro.InnerException.InnerException != null)
                        return erro.InnerException.InnerException.Message;
                    else
                        return erro.InnerException.Message;
                }
                else
                    return erro.Message;
            }
        }
       
    }
}
