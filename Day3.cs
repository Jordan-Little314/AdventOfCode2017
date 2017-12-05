using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{

    // Found some formulas on Google that work when used on Wolfram Alpha, but don't work here beacuse of how division works.
    // Oh well, got the answer correct on my AoC profile :)
    // My number - 368078
    // The answer - 371
    class Day3
    {
        private double getLayer(double n)
        {
            return Math.Ceiling(Math.Sqrt(n) - 1.0) / 2.0;
        }

        public double Part1(double n)
        {
            return Math.Abs(n - (getLayer(n) * ((Math.Ceiling((n - Math.Pow(1.0 + 2.0 * (getLayer(n) - 1.0), 2.0) / (2.0 * getLayer(n))) * 2.0 - 1.0) + 4.0 * (getLayer(n) - 1.0)) + 1.0)) + getLayer(n));
        }
    }
}
