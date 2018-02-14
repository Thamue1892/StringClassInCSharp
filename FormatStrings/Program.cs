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


            //Substrings
            string s3 = "Thamsanqa Mpofu";
            Console.WriteLine(s3.Replace("Thamsanqa", "Vuyolwethu"));
            Console.WriteLine(s3);

            //Index values are zero-based.
            int index = s3.IndexOf("q");
            Console.WriteLine("The index of q is: {0} ", index);
            Console.ReadKey();
        }
    }
}
