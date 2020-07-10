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
            Console.WriteLine("BEGIN!!!!!!");

            Deck deck = new Deck();
            deck.GetCard();

            Console.WriteLine("END!!!!!!!!");
            Console.ReadLine();
        }
    }

}
