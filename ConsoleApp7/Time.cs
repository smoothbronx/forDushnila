using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Time(int hours) {
            if (hours >= 0 && hours < 60)
            {
                this.hours = hours;
            }
            else throw new ArgumentOutOfRangeException("0>=hours>60");
             
        }

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public int GetAllSeconds()
        {
            return hours * (int) Math.Pow(60, 2) + minutes * 60 + seconds;
        }

        public void AddFiveSeconds()
        {
            if (seconds > 54)
            {
                if (minutes == 59)
                {
                    minutes = 0;
                    hours++;
                }

                seconds = (seconds + 5) % 60;
                minutes++;
            }

            seconds += 5;
        }
    }
}
