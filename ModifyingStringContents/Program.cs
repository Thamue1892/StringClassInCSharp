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
