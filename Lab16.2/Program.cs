using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product e in products)
            {
                if (e.Summa>maxProduct.Summa)
                {

                    maxProduct = e;
                }
                Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Summa}");
                Console.ReadKey();
            }
        }
    }
}
