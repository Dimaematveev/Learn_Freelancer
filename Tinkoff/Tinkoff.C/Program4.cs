using System;
using System.Collections.Generic;
using System.Linq;

namespace Tinkoff.C
{
    class Program4
    {
        static void Main4(string[] args)
        {
            List<int> numbers = new List<int>();
            do
            {
                var str = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(str))
                {
                    int a = Convert.ToInt32(str);
                    if (a == 0)
                    {
                        break;
                    }
                    else
                    {
                        numbers.Add(a);
                    }
                }
            } while (true);
            int max=2;

            int zn = numbers[1].CompareTo(numbers[0]);
            int maxTemp = 1;
            for (int i = 2; i < numbers.Count; i++)
            {
                if (zn == numbers[i].CompareTo(numbers[i-1]))
                {
                    maxTemp++;
                }
                else
                {

                    if (max<maxTemp+1)
                    {
                        max = maxTemp + 1;
                    }
                    maxTemp = 0;
                    zn = numbers[i].CompareTo(numbers[i - 1]);
                    if (zn==0)
                    {
                        zn = -2;
                    }
                }
            }
            if (max < maxTemp + 1)
            {
                max = maxTemp + 1;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

    }
}
