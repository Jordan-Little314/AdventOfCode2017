using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 d1 = new Day1();
            Console.WriteLine(d1.Part2(d1.d1In));

            Day2 d2 = new Day2();
            Console.WriteLine(d2.Part2());

            Day3 d3 = new Day3();
            Console.WriteLine(d3.Part1(368078.0));

            Day4 d4 = new Day4();
            Console.WriteLine(d4.Part2());
        }
    }
}
