using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Day2
    {
        public int Part1()
        {
            int sum = 0;

            foreach(string line in System.IO.File.ReadLines("../../Day2Input.txt"))
            {
                string[] input = line.Split();
                int min = Int32.Parse(input[0]), max = Int32.Parse(input[0]);
                for (int i = 1; i < input.Length; i++)
                {
                    if (Int32.Parse(input[i]) < min)
                        min = Int32.Parse(input[i]);
                    if (Int32.Parse(input[i]) > max)
                        max = Int32.Parse(input[i]);
                }

                sum += max - min;
            }

            return sum;
        }

        public int Part2()
        {
            int sum = 0;

            foreach (string line in System.IO.File.ReadLines("../../Day2Input.txt"))
            {
                string[] input = line.Split();
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if ((Int32.Parse(input[i]) % Int32.Parse(input[j]) == 0) && i != j)
                            sum += Int32.Parse(input[i]) / Int32.Parse(input[j]);
                    }
                }   
            }

            return sum;
        }
    }
}
