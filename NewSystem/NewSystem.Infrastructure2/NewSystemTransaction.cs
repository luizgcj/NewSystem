using Microsoft.EntityFrameworkCore.Storage;

namespace NewSystem.Infrastructure
{
    public class NewSystemTransaction
    {
        public NewSystemTransaction()
        {

        }

        public static IDbContextTransaction CreateDbContextTransaction(NewSystemContext db)
        {
            return db.Database.BeginTransaction(); 

        }
    }
}
