using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePeriod
{

    class Converter
    {
        private double aud;
        private double usd;

        public double AUD
        {
            get
            {
                return aud;
            }

            set
            {
                aud = usd * 0.74;
            }

        }

        
        public double USD
        {
            get
            {
                return usd;
            }

            set
            {
                usd = 1;
            }
        }
    }


 



    class TimePeriod
    {
        private int days;

        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                days = value;
            }
        }

        public int Weeks
        {
            set
            {
                days = value * 7;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod time = new TimePeriod();
            Console.WriteLine(time.Days);
        }
    }
}
