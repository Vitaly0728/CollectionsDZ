using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDZ
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int _id)
        {
            Id = _id;
            Name="Товар от " + DateTime.Now;
        }

    }
}
