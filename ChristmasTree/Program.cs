using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var HEIGHT = 7;
            var maxSpaces = HEIGHT;

            for (var i = 0; i <= HEIGHT; i++, maxSpaces--)
            {
                if (i < HEIGHT)
                {
                    // print spaces
                    for (var j = 0; j < maxSpaces; j++)
                    {
                        Console.Write(" ");
                    }
                    // print asterisks
                    for (var k = 0; k <= i; k++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (var j = 0; j < HEIGHT; j++)
                    {
                        Console.Write(" ");
                    }
                    // print asterisks
                    Console.WriteLine("*");
                }
                // print more spaces
                Console.WriteLine();
                

            }
        }
    }
}
