using System;
using System.Collections.Generic;
using System.Linq;

namespace Tinkoff.C
{
    class Program5
    {
        static void Main5(string[] args)
        {

            int N = Convert.ToInt32( Console.ReadLine());
            int[] mas1 = Console.ReadLine().Split(' ').Select(s=> Convert.ToInt32(s)).ToArray();
            int M = Convert.ToInt32(Console.ReadLine());
            int[] mas2 = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            int num1 = 0;
            int num2 = 0;
            int min = Math.Abs(mas2[0] - mas1[0]);

            int m1 = 0;
            int m2 = 0;
            int add = 0;
            while (m1 < N && m2 < M) 
            {
                if (mas1[m1]<=mas2[m2])
                {
                    
                    if (add==2)
                    {
                        int minTemp = Math.Abs(mas2[m2-1] - mas1[m1]);
                        if (min>minTemp)
                        {
                            min = minTemp;
                            num1 = mas1[m1];
                            num2 = mas2[m2 - 1];
                        }
                    }
                    add = 1;
                    m1++;
                }
                else
                {
                    if (add == 1)
                    {
                        int minTemp = Math.Abs(mas1[m1-1] - mas2[m2]);
                        if (min > minTemp)
                        {
                            min = minTemp;
                            num1 = mas1[m1 - 1];
                            num2 = mas2[m2];
                        }
                    }
                    add = 2;
                    m2++;
                }
            }
            if (m1 == N && m2 != M) 
            {
                if (add == 1)
                {
                    int minTemp = Math.Abs(mas1[m1 - 1] - mas2[m2]);
                    if (min > minTemp)
                    {
                        min = minTemp;
                        num1 = mas1[m1 - 1];
                        num2 = mas2[m2];
                    }
                }
            }

            if (m2 == M && m1 != N) 
            {
                if (add == 2)
                {
                    int minTemp = Math.Abs(mas2[m2 - 1] - mas1[m1]);
                    if (min > minTemp)
                    {
                        min = minTemp;
                        num1 = mas1[m1];
                        num2 = mas2[m2 - 1];
                    }
                }
            }
            Console.WriteLine($"{num1} {num2}");
        }

    }
}
