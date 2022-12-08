using System.Collections.Generic;

public static class Solution
{
    public static void DayOnePartOne()
    {
        List<string> list = new List<string>();
        list = System.IO.File.ReadAllLines(@"..\..\..\..\Day 1\input.txt").ToList();

        int sln = 0, cals = 0;
        foreach (string s in list)
        {
            if (String.IsNullOrEmpty(s))
            {
                if (cals >= sln)
                {
                    sln = cals;
                }
                cals = 0;
            }
            else
            {
                int temp = int.Parse(s);
                cals += temp;
            }
        }
        Console.WriteLine("Day 1 Part 1 Solution: " + sln);
    }

    public static void DayOnePartTwo()
    {
        List<string> list = new List<string>();
        list = System.IO.File.ReadAllLines(@"..\..\..\..\Day 1\input.txt").ToList();
        int cals = 0;
        int[] topThree = { 0, 0, 0 };
        foreach (string s in list)
        {
            if (String.IsNullOrEmpty(s))
            {
                if (cals >= topThree[0])
                {
                    topThree[2] = topThree[1];
                    topThree[1] = topThree[0];
                    topThree[0] = cals;
                }
                else if (cals >= topThree[1])
                {
                    topThree[2] = topThree[1];
                    topThree[1] = cals;
                }
                else if (cals >= topThree[2])
                {
                    topThree[2] = cals;
                }
                cals = 0;
            }
            else
            {
                int temp = int.Parse(s);
                cals += temp;
            }
        }

        Console.WriteLine("Day 1 Part 2 Solution: " + topThree.Sum());
    }

    public static void Main(string[] args)
    {
        DayOnePartOne();
        DayOnePartTwo();
        Console.ReadLine();
    }
}




