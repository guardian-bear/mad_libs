using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mad_libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fColor, sColor, verb; //Tag types of variable up front, don't need to indicate later

            Console.Write("Pick a color: ");
            fColor = Console.ReadLine();

            Console.Write("Pick another color: ");
            sColor = Console.ReadLine();

            Console.Write("Pick a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("Roses are " + fColor);
            Console.WriteLine("Violets are " + sColor);
            Console.WriteLine("I " + verb + " you.");

            Console.ReadLine();


        }
    }
}
