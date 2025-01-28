using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    internal class Part1
    {
        public List<string?> Poem { get; set; }
        
        private string _part= "Вот дом,\r\nКоторый построил Джек.";
        public Part1()
        {
            Poem=new List<string?> ();
        }
        public void AddPart()
        {            
            Poem.Add(_part);
        }
    }
}
