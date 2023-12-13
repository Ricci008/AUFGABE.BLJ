using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReiseMond
{
    internal class Mondreise
    {
        double speedKmh;


        public Mondreise(double speed)
        {

            speedKmh = speed;
        }
        public double getTravelDurationHours(double speedKmh)
        {
            double result = 384400.0 / speedKmh;
            return result;
        }

        public double getTravelDurationDays(double speedKmh)
        {
            double result = 384400.0 / speedKmh / 24;
            return result;

        }
    }
}
