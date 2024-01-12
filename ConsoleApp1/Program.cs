using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                double value1, value2;
                string cal;
                try
                {
                    Console.WriteLine("Enter value 1");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter value 2");
                    value2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter a number, please"); 
                    Console.ReadLine();
                    continue;
                }
            
                Console.WriteLine("Press +, -, *, /");
                cal = Console.ReadLine();
                switch (cal)
                {
                    case "+":
                        Console.WriteLine("You press +");
                        Console.WriteLine("Your solution = " );
                        Console.WriteLine(value1 + value2);
                        break;
                    case "-":
                        Console.WriteLine("You press -");
                        Console.WriteLine("Your solution = ");
                        Console.WriteLine( value1 - value2);
                        break;
                    case "*":
                        Console.WriteLine("You press *");
                        Console.WriteLine("Your solution = " + value1 * value2);
                        break;
                    case "/":
                        Console.WriteLine("You press /");
                        Console.WriteLine("Your solution = " + value1 / value2);
                        break;
                    default:
                        Console.WriteLine("Unknown Operation!");
                        break;
                       
                }
                Console.ReadLine();
            }
        }   
    }
}
