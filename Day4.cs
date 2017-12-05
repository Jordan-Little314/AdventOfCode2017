using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    // Overall this day was pretty much brute-forced.
    // I'm sure there's a much more elegant way of doing this, but I'm just aiming for a working solution, not the best solution :)
    class Day4
    {
        public int Part1()
        {
            int numValid = 0;

            foreach (string line in System.IO.File.ReadLines("../../Day4Input.txt"))
            {
                string[] input = line.Split();
                bool isValid = true;
                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                for (int i = 0; i < input.Length; i++)
                {
                    if (ht.Contains(input[i]))
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        ht.Add(input[i], i);
                    }
                }

                if (isValid)
                    numValid++;
                else
                    isValid = true;
            }

            return numValid;
        }

        public int Part2()
        {
            int numValid = 0;

            foreach (string line in System.IO.File.ReadLines("../../Day4Input.txt"))
            {
                string[] input = line.Split();
                bool isValid = true;
                for (int i = 0; i < input.Length; i++)
                {
                    int[] freq1 = new int[26];
                    foreach (char c in input[i])
                    {
                        freq1[c - 97]++;
                    }
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i].Length != input[j].Length)
                            continue;
                        int[] freq2 = new int[26];
                        bool areDifferent = false;
                        foreach(char c in input[j])
                        {
                            freq2[c - 97]++;
                        }
                        for (int k = 0; k < 26; k++)
                        {
                            if (freq1[k] != freq2[k])
                            {
                                areDifferent = true;
                                break;
                            }
                        }
                        if (!areDifferent)
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (!isValid)
                    {
                        break;
                    }
                }
                if (isValid)
                {
                    numValid++;
                }
            }

            return numValid;
        }
    }
}
