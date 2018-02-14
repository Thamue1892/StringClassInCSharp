using System;
using System.Text;

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

            //Accessing Individual Characters
            string s5 = "Printing backwards";
            for (int i = 0; i < s5.Length; i++)
            {
                Console.Write(s5[s5.Length-i-1]);
            }

            Console.WriteLine();

            //Using stringBuilder to modify individual characters
            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            StringBuilder sb = new StringBuilder(question);

            for (int i = 0; i < sb.Length; i++)
            {
                if (System.Char.IsLower(sb[i]) == true)
                    sb[i] = System.Char.ToUpper(sb[i]);
                else if (System.Char.IsUpper(sb[i]) == true)
                    sb[i] = System.Char.ToLower(sb[i]);
            }
            //Store the new string .
            string corrected = sb.ToString();
            Console.WriteLine(corrected);

        }
    }
}
