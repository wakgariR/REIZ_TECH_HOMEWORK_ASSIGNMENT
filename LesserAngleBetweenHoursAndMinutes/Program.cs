using System;

namespace LesserAngleBetweenHoursAndMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours:");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            double hour_angle = (hours % 12 + (double)minutes / 60) * 30;
            double minute_angle = minutes * 6;
            double angle = Math.Abs(hour_angle - minute_angle);

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine($"Lesser angle in degrees between hours arrow and minutes arrow{angle}.");
        }
    }
}
