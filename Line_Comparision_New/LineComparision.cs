using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_New
{
    public class LineComparision
    {
        int x_One, x_Three, y_One, y_Two;
        //Constructor
        public LineComparision(int x_One, int x_Two, int y_One, int y_Two)
        {
            this.x_One = x_One;
            this.x_Three = x_Two;
            this.y_One = y_One;
            this.y_Two = y_Two;
        }
        public void CompareTwoLines()
        {
            double length = Math.Sqrt(Math.Pow((x_Three - x_One), 2) + Math.Pow((y_Two - y_One), 2));
            Console.WriteLine("Length of the line : "+length);
        }
    }
}
