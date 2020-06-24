using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Durak.BL
{
    public class GameTable
    {
        public int CountPlayer { get; }
        public List<User> Players;

        public GameTable(int countPlayer)
        {
            CountPlayer = countPlayer;
            Players = new List<User>();
        }
        public bool AddPlayer(User player)
        {
            if (Players.Count < CountPlayer)
            {
                if (Players.Contains(player))
                {
                    return false;
                }
                Players.Add(player);
                return true;
            }
            return false;
        }

        public bool StartGame()
        {
            if (Players.Count == CountPlayer)
            {
                return true;
            }
            return false;
        }
    }
}
