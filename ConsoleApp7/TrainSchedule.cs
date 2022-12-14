using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class TrainSchedule : Time
    {
        public int trainNumber;
        public string direction;

        public TrainSchedule(int trainNumber, string direction, int hours, int minutes, int seconds) : base(hours, minutes, seconds)
        {
            this.trainNumber = trainNumber;
            this.direction = direction;
        }

        public int SomeMethod(int hours, int minutes, int seconds)
        {
            if (hours > this.hours)
            {
                throw new Exception("Вы пропустите этот поезд");
            }
            if (minutes > this.minutes) { throw new Exception("Возможно, вы уже пропустили этот поезд"); }
            if (seconds > this.seconds) { throw new Exception("Вы можете еще успеть на этот поезд"); }

            return (this.hours - hours) * 60 + (this.minutes - minutes);
        }
    }
}
