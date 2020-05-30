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

        public string NameSong { get; set; }
        public string Group { get; set; }
        public List<string> Original { get; set; } = new List<string>();
        public List<string> Translate { get; set; } = new List<string>();

       
    }
}
