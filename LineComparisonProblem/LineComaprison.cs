using System;

namespace LineComparisonProblem
{
    public class LineComaprison
    {
        public static void ChekingLength()
        {
            Console.WriteLine("Enter a Value Of x1,y1,x2,y2 Coordinate For Line1");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());
            var Length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("The Lenth Of the Line Is :" + Length1);
            Console.WriteLine("Enter a Value Of a1,b1,a2,b2 Coordinate For Line2");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            var Length2 = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine("The Lenth Of the Line Is :" + Length2);
            var result = Equals(Length1, Length2);
            if (result== false)
            {
                Console.WriteLine("The Lines Are Not Equal");
            }
            else
            {
                Console.WriteLine("The Lines Are Equal");
            }
        }
    }
}
