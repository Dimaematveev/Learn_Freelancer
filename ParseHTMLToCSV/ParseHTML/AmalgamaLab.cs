using AngleSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseHTML
{
    public class AmalgamaLab
    {
        public int NumberString  => Original.Count; 
        public string NameCSV { get; }
        public string NameSongOriginal { get; set; }
        public string NameSongTranslate { get; set; }
        public string NameGroup { get; set; }
        public List<string> Original { get; set; } = new List<string>();
        public List<string> Translate { get; set; } = new List<string>();
        public AmalgamaLab(string address)
        {
            var sp = address.Split('/');
            int len = sp.Length;
            NameCSV = $"{sp[len-2]}-{sp[len-1].Replace(".html","")}.csv";
        }

        public void ToConsole()
        {


            Console.WriteLine($"Название группы: {NameGroup}");
            
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Песня:");
            int maxOrig = Original.Max(x=>x.Length);
            int maxTrans = Translate.Max(x => x.Length);
            Console.WriteLine($"|{"Оригинал".PadRight(maxOrig)} | {"Перевод".PadRight(maxTrans)}|");
            Console.WriteLine($"|{NameSongOriginal.PadRight(maxOrig)} | {NameSongTranslate.PadRight(maxTrans)}|");
            Console.WriteLine($"|{new string('_', maxOrig + 1)}|{new string('_', maxTrans + 1)}|");
            for (int i = 0; i < NumberString; i++)
            {
                Console.WriteLine($"|{Original[i].PadRight(maxOrig)} | {Translate[i].PadRight(maxTrans)}|");
            }
            Console.WriteLine($"|{new string('_', maxOrig + 1)}|{new string('_', maxTrans + 1)}|");

        }

        public async void SaveCSV()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(NameCSV, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < NumberString; i++)
                    {
                        await sw.WriteLineAsync($"{Original[i]} ; {Translate[i]}");
                    }
                }

                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
