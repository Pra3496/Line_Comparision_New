namespace Line_Comparision_New
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come To Line Comparision Problem");

            LineComparision lineComparision = new LineComparision(15, 24, 17, 8);
            lineComparision.CompareTwoLines();
            Console.ReadKey();
        }
    }
}