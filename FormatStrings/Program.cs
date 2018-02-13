using System;

namespace FormatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("Enter a number ");
            string input = Console.ReadLine();

            //Convert the input string to an int.
            int j;
            Int32.TryParse(input, out j);

            //Write a different string each iteration
            string s;
            for (int i = 0; i < 10; i++)
            {
                //Simple format string with no alignment formatting
                s = string.Format("{0} times {1} = {2}", i, j, (i * j));
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
