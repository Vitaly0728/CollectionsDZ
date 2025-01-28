using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDZ
{
    internal class Shop
    {
        private List<Item> _items;
        private List<Customer> _customers;

        public Shop()
        {
            _items = new List<Item>(); 
            _customers = new List<Customer>();
        }
        public void RegisterObserver(Customer visitor)
        {
            _customers.Add(visitor);
        }
        public string Add(Item item)
        {
            _items.Add(item);
            return $"Добавлен товар - {item.Name}\n" +
                $"Индекс товара - {item.Id}";
        }
        public string Remove(int id)
        {            
            foreach (Item item in _items)
            {
                if (item.Id == id)
                {
                     _items.Remove(item);
                    return $"Удален товар - {item.Name}\n" +
                    $"Индекс товара - {item.Id}";
                }               
            }
            return "Такого товара нет!";
        }
        public void NotifyObservers(string eventMessage)
        {
            foreach (var visitor in _customers)
            {
                visitor.OnItemChanged(eventMessage);
            }
        }
    }
}
