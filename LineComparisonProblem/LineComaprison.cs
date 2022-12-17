using System;

namespace LineComparisonProblem
{
    public class LineComaprison
    {
        public static void ChekingLength()
        {
            Console.WriteLine("Enter a Value Of x1 Coordinate");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Value Of y1 Coordinate");
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Value Of x2 Coordinate");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Value Of y2 Coordinate");
            int y2=Convert.ToInt32(Console.ReadLine());
            var Length = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("The Lenth Of the Line Is :" + Length);
        }
    }
}
