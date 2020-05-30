using System;

namespace ParseHTML
{
    /*
        * Вытянуть отсюда https://www.amalgama-lab.com/songs/l/little_big/uno.html  
        * английский и русский текст в Файл с названием little_big_uno.csv - англ;русский
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==ConsoleApp2==");
            Console.WriteLine();


            ParserAmalgamaLab parser = new ParserAmalgamaLab();
            var amalgamaLab = parser.GetSong("https://www.amalgama-lab.com/songs/l/little_big/uno.html").Result;

            amalgamaLab.ToConsole();
            amalgamaLab.SaveCSV();
            Console.WriteLine(amalgamaLab.NameCSV);
            Console.ReadLine();
        }
    }
}
