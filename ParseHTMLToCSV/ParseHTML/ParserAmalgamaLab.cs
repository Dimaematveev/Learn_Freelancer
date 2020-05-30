using AngleSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseHTML
{
    class ParserAmalgamaLab
    {
        public async Task<AmalgamaLab> GetSong(string address)
        {
            // конфигурация
            var config = Configuration.Default.WithDefaultLoader();
            // 
            //var address = "https://www.amalgama-lab.com/songs/l/little_big/uno.html";
            // асинхронно загружаем страницу
            var document = await BrowsingContext.New(config).OpenAsync(address);


            AmalgamaLab result = new AmalgamaLab();

            ////--Группа
            var cellSelector = @"div#songs_nav a";
            var cell = document.QuerySelector(cellSelector);
            result.Group = cell.TextContent.Trim();


            ////--Название песни
            cellSelector = @"div#songs_nav li.active";
            cell = document.QuerySelector(cellSelector);
            result.NameSong = cell.TextContent.Trim();


            //--Оригинальный текст
            cellSelector = @"div#click_area div.string_container div.";
            var cells = document.QuerySelectorAll(cellSelector + "original");
            var pars = cells.Select(m => m.TextContent.Trim());
            result.Original = new List<string>(pars);

            //--перевод текст
            cells = document.QuerySelectorAll(cellSelector + "translate");
            pars = cells.Select(m => m.TextContent.Trim());
            result.Translate = new List<string>(pars);
            return result;
        }
    }
}
