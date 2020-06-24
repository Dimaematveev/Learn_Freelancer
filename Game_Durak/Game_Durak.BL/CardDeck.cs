using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Durak.BL
{
    public class CardDeck
    {
        Suit[] Suits;
        ValueCart[] ValueCarts;

        public CardDeck()
        {
            Suits = new Suit[]
            {
                new Suit("Черви"),
                new Suit("Буби"),
                new Suit("Пики"),
                new Suit("Трефы"),
            };
            ValueCarts = new ValueCart[]
            {
                new ValueCart(2,"2"),
                new ValueCart(3,"3"),
                new ValueCart(4,"4"),
                new ValueCart(5,"5"),
                new ValueCart(6,"6"),
                new ValueCart(7,"7"),
                new ValueCart(8,"8"),
                new ValueCart(9,"9"),
                new ValueCart(10,"10"),
                new ValueCart(11,"В"),
                new ValueCart(12,"Д"),
                new ValueCart(13,"К"),
                new ValueCart(14,"Т"),
            };
        }
    }
}
