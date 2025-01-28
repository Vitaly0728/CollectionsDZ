namespace CollectionsDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer("Валентин");
            var customer1 = new Customer("Петр");
            shop.RegisterObserver(customer);           
            
            while (true)
            {
                Console.WriteLine("Введите А для добавдения товара. \n" +
                    "Введите D для удаления товара. \n" +
                    "Введите Х для выхода из приложения.");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "A":
                        Console.WriteLine("Введите идентификатор товара.");
                        int _id = Convert.ToInt32(Console.ReadLine());
                        var item = new Item(_id);
                        shop.NotifyObservers(shop.Add(item));
                        break;

                    case "D":
                        Console.WriteLine("Введите идентификатор товара.");
                        int id = Convert.ToInt32(Console.ReadLine());
                        shop.NotifyObservers(shop.Remove(id)); 
                        break;

                    case "X": return;

                    default:
                        Console.WriteLine("Не правильный ввод!");
                        break;
                }
            }

        }
    }
}
