namespace Line_Comparision_New
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWel Come To Line Comparision Problem\n");

            LineComparision lineOne = new LineComparision(5, 1, 7, 4);
            double lineLengthOne = lineOne.CompareTwoLines();

            LineComparision lineTwo = new LineComparision(15, 14, 17, 8);
            double lineLengthTwo = lineTwo.CompareTwoLines();


            if (lineLengthOne.CompareTo(lineLengthTwo) == 0)
                Console.WriteLine("Both lines are equal");
            else if (lineLengthOne.CompareTo(lineLengthTwo) > 0)
                Console.WriteLine("Lenght of line one : "+lineLengthOne+" is greater than lenght of line two : " + lineLengthTwo);
            else
                Console.WriteLine("Lenght of line one : "+lineLengthOne+" is lesser than length of line two : "+lineLengthTwo);
            Console.ReadKey();

        }
    }
}