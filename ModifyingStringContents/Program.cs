using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ModifyingStringContents
{
    class Program
    {
        string searchFor;
        string replaceWith;
        static void Main(string[] args)
        {
            Program app = new Program();
            string s = "The mountains are behind the clouds today.";

            //Replace one substring with another with string.Replace
            //Only exact matches are supported.
            s = s.Replace("mountains", "peaks");
            System.Console.WriteLine(s);

            //Use Regex.Replace for more flexibility.
            //Replace "the" or "The" with "many" or "Many".
            //Using System.Text.RegularExpressions
            app.searchFor = "the";
            app.replaceWith = "many";
            s = Regex.Replace(s, app.searchFor, app.replaceMatchCase, RegexOptions.IgnoreCase);
            Console.WriteLine(s);

            //Replace all occurrences of one char with another.
            s = s.Replace(' ', '_');
            Console.WriteLine(s);

            //Remove a substring from the middle of the string.
            string temp = "many_";
            int i = s.IndexOf(temp);
            if (i>=0)
            {
                s = s.Remove(i, temp.Length);
            }
            Console.WriteLine(s);
            Console.WriteLine();

            //Remove trailing and leading whitespace.
            string s2 = " I'm wider than I need to be.        ";
            temp = s2.Trim();
            Console.WriteLine(temp);
            Console.WriteLine();

            //Accessing individual characters in a string using array notation.
            string str = "The quick brown fox jumped over the fence";
            Console.WriteLine(str);
            Console.WriteLine();

            char[] chars = str.ToCharArray();
            int animalIndex = str.IndexOf("fox");
            if (animalIndex !=-1)
            {
                chars[animalIndex++] = 'c';
                chars[animalIndex++] = 'a';
                chars[animalIndex] = 't';
            }

            string str2 = new string(chars);
            Console.WriteLine(str2);
            Console.WriteLine();

            //Using unsafe code to modify strings.
            string s1 = "Hello";
            string s3 = "Hello";

      
        }

        private string replaceMatchCase(Match m)
        {
            //Test whether the match is capitalized
            if (Char.IsUpper(m.Value[0]) == true)
            {
                //Capitalize the replacement string
                StringBuilder sb = new StringBuilder(replaceWith);
                sb[0] = (char.ToUpper(sb[0]));
                return sb.ToString();
            }
            else
            {
                return replaceWith;
            }
        }
    }
}
