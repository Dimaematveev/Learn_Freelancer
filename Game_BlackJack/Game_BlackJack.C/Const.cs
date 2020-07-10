using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_BlackJack.C
{
    public static class Const
    {
        public static string[] Suits = new string[] { "heart", "diamond", "club", "spade" };
        public static string[] Ranks = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
        public static Dictionary<string, string> Printed = new Dictionary<string, string> {
            { "2", "2" }, 
            { "3", "3" }, 
            { "4", "4" }, 
            { "5", "5" }, 
            { "6", "6" }, 
            { "7", "7" }, 
            { "8", "8" }, 
            { "9", "9" }, 
            { "10", "10" }, 
            { "jack", "V" }, 
            { "queen", "D" }, 
            { "king", "K" }, 
            { "ace", "A" }, 
        };
}
}
