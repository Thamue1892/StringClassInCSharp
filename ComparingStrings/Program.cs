using System;

namespace ComparingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Internal strings that will never be localized.
            string root = @"C:\users";
            string root2 = @"C:\Users";

            //Use the overload of the Equals mehod that specifies a StringComparison.
            bool result = root.Equals(root2, StringComparison.Ordinal);

            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", root, root2,
                            result ? "equal." : "not equal.");

            Console.WriteLine();

            
        }
    }
}
