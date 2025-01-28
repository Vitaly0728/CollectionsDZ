using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDZ
{
    internal class Customer
    {
        private readonly string _visitorName;

        public Customer(string visitorName)
        {
            _visitorName = visitorName;
        }

        public void OnItemChanged(string eventDetails)
        {
            Console.WriteLine($"Пользователь {_visitorName} получил сообщение!\n" + eventDetails);
        }

    }
}
