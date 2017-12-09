using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Day5
    {
        public int Part1()
        {
            List<int> nums = new List<int>();
            int steps = 0;

            foreach (string line in System.IO.File.ReadLines("../../Day5Input.txt"))
            {
                nums.Add(int.Parse(line));
            }

            for (int i = 0; i < nums.Count;)
            {
                int temp = nums[i];
                nums[i]++;
                i += temp;
                steps++;
            }

            return steps;
        }

        public int Part2()
        {
            List<int> nums = new List<int>();
            int steps = 0;

            foreach (string line in System.IO.File.ReadLines("../../Day5Input.txt"))
            {
                nums.Add(int.Parse(line));
            }

            for (int i = 0; i < nums.Count;)
            {
                int temp = nums[i];
                if (temp >= 3)
                    nums[i]--;
                else 
                    nums[i]++;
                i += temp;
                steps++;
            }

            return steps;
        }
    }
}
