using NewSystem.Infrastructure;
using System;
using System.Configuration;
using System.Linq;

namespace NewSystem.CA
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NewSystemContext();
            var cidades = (from q in db.Cidades select q).ToArray();
            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade.Descricao);
            }

            Console.ReadLine();
        }
    }
}
