using System;

namespace Clock
{
    class Program
    {
        static double Clock(int hour, int min)
        {
            double result;
            result = (hour * 30 + min * 0.5) - (min * 6);
            if (result < 0)
                result *= -1;
            return result;
        }
        static void Main(string[] args)
        {
            int hour, minute;
            Console.Write("How many hours?");
            hour = int.Parse(Console.ReadLine());
            Console.Write("How many minutes?");
            minute = int.Parse(Console.ReadLine());
            Console.WriteLine("It is {2} degrees at {0}:{1}.", hour, minute, Clock(hour, minute));
        }
    }
}
