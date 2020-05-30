using System;

namespace ParseHTML
{
    /*
        * Вытянуть отсюда https://www.amalgama-lab.com/songs/l/little_big/uno.html  
        * английский и русский текст в Файл с названием little_big_uno.csv - англ;русский
    */
    class Program
    {
        private static void Main(string[] args)
        {
            ParserAmalgamaLab parser = new ParserAmalgamaLab();

            string[] paths = new string[]
            {
                "https://www.amalgama-lab.com/songs/l/little_big/uno.html",
                "https://www.amalgama-lab.com/songs/n/n_dubz/playing_with_fire.html",
            };

            foreach (var path in paths)
            {
                Console.WriteLine($"{path}");
                var amalgamaLab = parser.GetSong(path).Result;
                amalgamaLab.ToConsole();
                amalgamaLab.SaveCSV();
                Console.WriteLine(amalgamaLab.NameCSV);
            }
           
            
            Console.ReadLine();
        }
    }
}
