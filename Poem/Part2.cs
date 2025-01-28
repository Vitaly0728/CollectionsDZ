using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    internal class Part2
    {
        public List<string>? Poem { get; set; }
        private string _part = "А это пшеница,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        public Part2()
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
