using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    internal class Part3
    {
        public List<string>? Poem { get; set; }
        private string _part = "А это веселая птица-синица,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        public Part3()
        {
            Poem = new List<string?>();
        }
        public void AddPart(List<string> str)
        {
            Poem.AddRange(str);
            Poem.Add(_part);
        }
    }
}
