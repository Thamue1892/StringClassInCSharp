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

            //Using a static method
            bool areEqual = string.Equals(root, root2, StringComparison.Ordinal);

            //String interning.Are these really two distinct objects?
            string a = "The computer ate my source code.";
            string b = "The computer ate my source code.";

            //ReferenceEquals returns true if both objects
            //point to the same location in memory
            if (String.ReferenceEquals(a, b))
                Console.WriteLine("a and b are interned.");
            else
                Console.WriteLine("a and b are not interned.");

            //Using string.Copy method to avoid interning
            string c = String.Copy(a);

            if (String.ReferenceEquals(a, c))
                Console.WriteLine("a and c are interned.");
            else
                Console.WriteLine("a and c are not interned.");
        }
    }
}
