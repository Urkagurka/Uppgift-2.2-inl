using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("hur många meter hoppade elin?");
            int meter_elin=int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många meter hoppade Alma?");
            int meter_alma=int.Parse(Console.ReadLine()); 

            Console.WriteLine("Elin hoppade " + (meter_elin - meter_alma) + " mer än alma");





        }
    }
}