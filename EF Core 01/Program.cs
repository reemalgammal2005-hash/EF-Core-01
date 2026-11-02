using Microsoft.EntityFrameworkCore;

namespace EF_Core_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookStoreContext BdContext = new BookStoreContext();
            BdContext.Database.Migrate();

            Console.WriteLine($"Database created: {BdContext.Database.CanConnect()}");
            Console.WriteLine($"Database name   : {BdContext.Database.GetDbConnection().Database}");
            Console.WriteLine();
            foreach (var entityType in BdContext.Model.GetEntityTypes())
            {
                Console.WriteLine($"Table: {entityType.GetTableName()}");
                foreach (var p in entityType.GetProperties())
                    Console.WriteLine($"   - {p.Name} ({p.ClrType.Name}) {(p.IsPrimaryKey() ? "[PK]" : "")}");
                Console.WriteLine();
            }
        }
    }
}
