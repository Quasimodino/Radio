using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.WriteLine(" ");
            radio.volume=float.Parse(Console.ReadLine());
            Console.WriteLine("{0}", radio.aumentavolume());
            Console.WriteLine("{0}", radio.diminuiscivolume());
            Console.ReadLine();
        }
    }
}
