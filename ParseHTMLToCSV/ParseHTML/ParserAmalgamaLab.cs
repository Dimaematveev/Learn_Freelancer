using AngleSharp;
using AngleSharp.Dom;
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
            // асинхронно загружаем страницу
            var document = await BrowsingContext.New(config).OpenAsync(address);

            AmalgamaLab result = new AmalgamaLab(address);
            ////--Группа
            var cellSelector = @"div#songs_nav a";
            var cell = document.QuerySelector(cellSelector);
            result.NameGroup = GetTextNotChild(cell).Trim();
            result.NameGroup = result.NameGroup.TrimEnd(':');
            ////--Название песни оригинал
            cellSelector = @"div.texts.col h2.original";
            cell = document.QuerySelector(cellSelector);
            result.NameSongOriginal = GetTextNotChild(cell).Trim();
            ////--Название песни оригинал
            cellSelector = @"div.texts.col h2.translate";
            cell = document.QuerySelector(cellSelector);
            result.NameSongTranslate = GetTextNotChild(cell).Trim();

            cellSelector = @"div#click_area div.string_container div.";
            //--Оригинальный текст
            var cells = document.QuerySelectorAll(cellSelector + "original");
            var pars = cells.Select(m => GetTextNotChild(m).Trim());
            result.Original = new List<string>(pars);

            //--перевод текст
            cells = document.QuerySelectorAll(cellSelector + "translate");
            pars = cells.Select(m => GetTextNotChild(m).Trim());
            result.Translate = new List<string>(pars);
            return result;
        }

        private string GetTextNotChild(IElement element)
        {
            string ret = element.TextContent;
            foreach (var children in element.Children)
            {
                ret = ret.Replace(children.TextContent, "");
            }
            return ret;
        }
    }
}
