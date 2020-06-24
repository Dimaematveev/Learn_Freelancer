using Game_Durak.BL;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Durak.C
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameTable = new GameTable(4);
            var user1 = new User(0.ToString());
            var db3 = gameTable.AddPlayer(user1);
            Console.WriteLine(db3);
            for (int i = 0; i < 5; i++)
            {
                var user = new User(i.ToString());
                var db1= gameTable.AddPlayer(user);
                Console.WriteLine(db1);
            }
            var db2 = gameTable.StartGame();
            Console.WriteLine(db2);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
