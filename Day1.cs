using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Day1
    {
        public string d1In = System.IO.File.ReadAllText("../../Day1Input.txt");

        public int Part1(string str)
        {
            int sum = 0;


            for (int i = 0, j = 1; j < d1In.Length; i++, j++)
            {
                if (str[i] == str[j])
                    sum += (int)char.GetNumericValue(str[i]);
            }
            if (str[0] == str[d1In.Length - 1])
                sum += (int)char.GetNumericValue(str[0]);

            return sum;
        }

        public int Part2(string str)
        {
            int sum = 0;


            for (int i = 0, j = d1In.Length / 2; i < d1In.Length / 2; i++, j++)
            {
                if (str[i] == str[j])
                    sum += (int)char.GetNumericValue(str[i]);
            }


            return sum * 2;
        }
    }
}