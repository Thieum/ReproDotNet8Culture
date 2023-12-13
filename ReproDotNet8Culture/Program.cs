namespace ReproDotNet8Culture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("d", System.Globalization.CultureInfo.CreateSpecificCulture("en-CA")));
        }
    }
}
