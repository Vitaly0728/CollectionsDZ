﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    internal class Part5
    {
        public List<string>? Poem { get; set; }
        private string _part = "Вот пес без хвоста,\r\nКоторый за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек.";
        public Part5()
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
