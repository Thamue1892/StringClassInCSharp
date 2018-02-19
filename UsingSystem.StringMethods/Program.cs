using System.Threading;

namespace UsingSystem.StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Sie tanzen auf der StraBe.";
            string second = "Sie tanzen auf de Strasse.";

            System.Console.WriteLine("First sentence is {0}",first);
            System.Console.WriteLine("Second sentence is {0}",second);

            //Store CultureInfo for the current culture.Note that the original culture
            //can be set and retrieved on the current thread object.
            Thread thread = Thread.CurrentThread;
            System.Globalization.CultureInfo originalCulture = thread.CurrentCulture;

            //set culture to en-US
            thread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //For culture-sensitive comparisons,use the String.Compare
            //overload that takes a stringComparison value.
        }
    }
}
