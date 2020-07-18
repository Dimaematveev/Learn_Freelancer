using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_BlackJack.C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BEGIN!!!!!!");
            var g =new Game();
            g.StartGame();



            Console.WriteLine("END!!!!!!!!");
            Console.ReadLine();
        }
    }

}
