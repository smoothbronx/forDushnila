using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trainShedule = new TrainSchedule(1, "Москва", 14, 30, 0);
            Console.WriteLine(trainShedule.SomeMethod(13, 30, 0));
        }
    }
}