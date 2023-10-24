using DatabaseFirst.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyStoreContext MyStore = new MyStoreContext();
            var products = from p in MyStore.Products
                                                 select new { p.ProductName, p.CategoryId };
            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryID:{p.CategoryId}");
            }
            Console.WriteLine("_________________________________");
            IQueryable<Caretory> cats = MyStore.Caretories.Include(c => c.Products);
            foreach (var c in cats)
            {
                Console.WriteLine($"CatoryId:{c.CaretorytId} has {c.Products.Count} products");
            }
            Console.ReadLine();
        }

    }
}
