using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            long myNumber = 0;
            string cont = "y";
            long factnum = 0;
            while (cont == "y" || cont == "Y")
            {

                myNumber = GetInput();
                factnum = factorial(myNumber);

                Console.WriteLine(factnum);
                cont = ynInput();
            }
        }
        public static int GetInput()
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.WriteLine("Please enter an integer between 1 and 20: ");
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum < 1 || exitNum > 20)
                {
                    Console.WriteLine("That's not valid input!");
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
        static string ynInput()
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input == "n") || (input == "Y") || (input == "N"))
                {
                    invalid = false;
                }
            }
            return input;
        }
        public static long factorial (long num)
        {
           if (num > 1)
            {
                num = num * factorial(num - 1);

            }
            return num;
        }
    }
}
