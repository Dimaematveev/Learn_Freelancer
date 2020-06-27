using System;
using System.Linq;

namespace Tinkoff.C
{
    class Program1
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var ch = str.ToLower().Where(x=>x>='a'&&x<='z').ToArray();
            int len = ch.Length;
            var ans = "YES";
            if (len != 0)
            {
                for (int i = 0; i < len/2 +1; i++)
                {
                    if (ch[i]!=ch[len-i -1])
                    {
                        ans = "NO";
                        break;
                    }
                }
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
