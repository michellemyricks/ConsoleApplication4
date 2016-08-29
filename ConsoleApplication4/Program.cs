using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Learn your squares and cubes!\n");
            Console.WriteLine("Enter an integer:");
            int answer = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Number       Squared       Cubed        ");
            Console.WriteLine("======       =======       =====        ");
            int answersquared = answer * answer;
            int answercubed = answersquared * answer;
            string output = Convert.ToString(answer, 10) + "             " + Convert.ToString(answersquared, 10) + "         " + Convert.ToString(answercubed, 10);
            Console.WriteLine(output);
            
            
            Console.WriteLine("Continue? (y/n):");
            string response = Console.ReadLine();
        }
    }
}
