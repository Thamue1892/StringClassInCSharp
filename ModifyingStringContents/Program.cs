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


        }
    }
}
