using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Book : Product
    {
        public string genre { get; set; }
        public Book(double Price, double Count, double No, string Name, string Genre) :base(Price, Count, No, Name)
        {
            genre = Genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Qiymet:{price},say:{count},no:{no},janr:{genre}");
        }
    }
}
