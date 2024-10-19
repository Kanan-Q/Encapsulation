using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Product
    {
        private double _price;
        private double _count;
        public double price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("kitab pulsuz deyil");
                }
            }
        }
        public double count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    Console.WriteLine("kitab sayi en azi 1 dene olsunki satis ede bilek");
                }
            }
        }
        public double no { get; set; }
        public string name { get; set; }
        public Product(double Price, double Count, double No, string Name)
        {
            name = Name;
            price = Price;
            no = No;
            count = Count;
        }
    }
}

