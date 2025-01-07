using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetGen
{
    public class Product
    {
        public string Name { get; set; } ="";
        public string Description { get; set; } ="";

        public void GetProductName()
        {
            Console.WriteLine("Hi, I am Adny! I'm here to help you create an attractive tweet for your smartwatch launch.");
            Console.WriteLine("What's the name of your product?");
            Name = Console.ReadLine();
        }

        public void GetProductDescription()
        {
            Console.WriteLine("Describe your smartwatch in a few sentences:");
            Description = Console.ReadLine();

        }

      

    }
}