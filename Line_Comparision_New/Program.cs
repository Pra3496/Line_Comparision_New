namespace Line_Comparision_New
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWel Come To Line Comparision Problem\n");

            LineComparision lineOne = new LineComparision(15, 24, 17, 8);
            double lineLengthOne = lineOne.CompareTwoLines();

            LineComparision lineTwo = new LineComparision(25, 3, 15, 21);
            double lineLengthTwo = lineTwo.CompareTwoLines();

            
            if (lineLengthOne.Equals(lineLengthTwo))
            { Console.WriteLine("Both lines are equal"); }
            else
            { Console.WriteLine("Both lines are unequal"); }
            Console.ReadKey();
          
        }
    }
}