using System;

namespace FindDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find out day");
            Console.WriteLine("Enter date:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year:");
            int y = Convert.ToInt32(Console.ReadLine());
            int td,y0,x,m0,d0;
            y0 = y - (14 - m ) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + 31 * m0 / 12) % 7;
            switch(d0)
            {
                case 0:Console.WriteLine("Day is Sunday");
                    break;
                case 1:Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");
                    break;
            }

        }
    }

}