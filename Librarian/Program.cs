namespace Librarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var biblio= new Books();
            while (true)
            {
                Console.WriteLine("Введите 1 для добавдения книги. \n" +
                    "Введите 2 для показа списка непрочитанного. \n" +
                    "Введите 3 для выхода из приложения.");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        biblio.AddBooks();
                        break;

                    case "2":
                        biblio.DisplayProgressBooks();
                        break;

                    case "3": return;

                    default:
                        Console.WriteLine("Не правильный ввод!");
                        break;
                }
            }
        }
    }
}
