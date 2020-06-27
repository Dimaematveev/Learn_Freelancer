using System;
using System.Collections.Generic;
using System.Linq;

namespace Tinkoff.C
{
    class Program3
    {
        static void Main3(string[] args)
        {
            string str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine(0);
                return;
            }
            List<string> all = new List<string>();
            all.Add($"{str[0]}");
            for (int i = 1; i < str.Length; i++)
            {
                all.Add($"{str[i - 1]}{str[i]}");
                all.Add($"{str[i]}");
            }
            
            for (int i = 0; i < all.Count; i++)
            {

                bool b = true;
                for (int j = 0; j < 33; j++)
                {
                    if (all[i].Equals(j.ToString()))
                    {
                        b = false;
                        break;
                    }
                    
                }
                if (b)
                {
                    all.RemoveAt(i);
                    i--;
                }
            }
            List<List<string>> New = new List<List<string>>();
            New.Add(new List<string>(){ all[0] });
            for (int i = 1; i < all.Count; i++)
            {
                if (all[i-1].Length==1 && all[i].Length==1)
                {
                    New.Add(new List<string>(){ all[i] });
                }
                else
                {
                    New.Last().Add(all[i]);
                }
            }
            for (int i = 0; i < New.Count; i++)
            {
                if (New[i].Count==1)
                {
                    New.RemoveAt(i);
                    i--;
                }
            }
            int count = 1;
            foreach (var item in New)
            {
                count *=  CountInterpretation(item);
            }
            
            Console.WriteLine(count);
        }

        public static int CountInterpretation(List<string> str)
        {
            List<string> NewList = new List<string>();
            for (int i = 0; i < str.Count; i+=2)
            {
                NewList.Add(str[i]);
            }
            return Coun(NewList);
        }
        private static int Coun(List<string> num)
        {
            if (num.Count < 3) 
            {
                return num.Count;
            }
            else
            {
                return Coun(num.Skip(1).ToList()) + Coun(num.Skip(2).ToList());
            }
        }
    }
}
