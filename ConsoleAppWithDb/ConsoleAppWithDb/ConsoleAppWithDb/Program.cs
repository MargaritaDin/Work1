using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppWithDb.Repository;

namespace ConsoleAppWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationContext())
            {
                var list = dbContext.Postashalniks.ToList();
                Console.WriteLine(list.Count);
            }
        }
    }
}
