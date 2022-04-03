//using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    // "Product"
    public class Product
    {
        
        private List<string> parts;
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            //Adding parts
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n\nProduct completed as below :\n");
            Console.WriteLine("********************************\n");
            foreach (string part in parts)
                Console.WriteLine(part+"\n");
        }
    }
}
