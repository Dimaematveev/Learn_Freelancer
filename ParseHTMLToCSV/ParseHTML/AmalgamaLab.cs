using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseHTML
{
    public class AmalgamaLab
    {
        public int NumberString  => Original.Count; 
        public string NameSong { get; set; }
        public string NameGroup { get; set; }
        public List<string> Original { get; set; } = new List<string>();
        public List<string> Translate { get; set; } = new List<string>();

        public void ToConsole()
        {


            Console.WriteLine($"Название группы: {NameGroup}");
            Console.WriteLine($"Название песни: {NameSong}");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Песня:");
            int maxOrig = Original.Max(x=>x.Length);
            int maxTrans = Translate.Max(x => x.Length);
            Console.WriteLine($"|{"Оригинал".PadRight(maxOrig)} | {"Перевод".PadRight(maxTrans)}|");
            Console.WriteLine($"|{new string('_', maxOrig + 1)}|{new string('_', maxTrans + 1)}|");
            for (int i = 0; i < NumberString; i++)
            {
                Console.WriteLine($"|{Original[i].PadRight(maxOrig)} | {Translate[i].PadRight(maxTrans)}|");
            }
            Console.WriteLine($"|{new string('_', maxOrig + 1)}|{new string('_', maxTrans + 1)}|");

        }

    }
}
