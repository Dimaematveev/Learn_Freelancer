using System;
using System.Collections.Generic;

namespace Game_BlackJack.C
{
    public class Card
    {
        public string Suit;
        public string Rank;
        public int Points;
        public string Picture;
        

        public Card(string suit, string rank, int points, string picture)
        {
            Suit = suit;
            Rank = rank;
            Points = points;
            Picture = picture;
        }

        public override string ToString()
        {
            return $"Suit={Suit,10}, Rank={Rank,6}, Point={Points,2}, Picture={Picture,2}.";
        }
    }
    public class Deck
    {
        public List<Card> Cards;
        public int CountCard { get => Cards.Count; }
        public Deck()
        {
            Cards = CreateDesk();
            ShuffleTheDeck();
        }

        //создание колоды
        private List<Card>CreateDesk()
        {
            List<Card> cards = new List<Card>();
            foreach (var suit in Const.Suits)
            {
                foreach (var rank in Const.Ranks)
                {
                    if (int.TryParse(rank, out int point))
                    {
                        cards.Add(new Card(suit, rank, point, Const.Printed[rank] ));
                    }
                    else
                    {
                        if (rank=="ace")
                        {
                            point = 11;
                        }
                        else
                        {
                            point = 10;
                        }
                        cards.Add(new Card(suit, rank, point, Const.Printed[rank]));
                    }
                   
                }
            }
            return cards;
        }

        //перемешивание колоды
        public void ShuffleTheDeck()
        {
            Random rnd = new Random();
            for (int i = 0; i < CountCard; i++)
            {
                int j;
                do
                {
                    j = rnd.Next(0, CountCard);
                } while (j == i);
                // обменять значения data[j] и data[i]
                var temp = Cards[j];
                Cards[j] = Cards[i];
                Cards[i] = temp;
            }
        }

        //вытащить карту
        public Card GetCard()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

        public override string ToString()
        {
            return $"Количество карт = {CountCard}.";
        }
    }

}
