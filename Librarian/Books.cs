using System.Collections.Concurrent;

namespace Librarian
{
    internal class Books
    {
        private ConcurrentDictionary<string, int> _keyValueBooks;

        public Books()
        {
            _keyValueBooks = new ConcurrentDictionary<string, int>();
            Task.Run(ProgressReadBooks);
        }
        public void AddBooks()
        {
            Console.WriteLine("Введите название книги.");
            string? nameBook = Console.ReadLine();
            _keyValueBooks.TryAdd(nameBook, 0);
            Console.WriteLine($"Книга с названием - {nameBook} добавлена!");
        }
        public void  DisplayProgressBooks()
        {
            Console.WriteLine("Текущий прогресс чтения книг:");
            foreach (var book in _keyValueBooks)
            {
                Console.WriteLine($"Книга: {book.Key}, Прогресс: {book.Value}%");
            }
        }
        private async Task ProgressReadBooks()
        {
            while (true)
            {
                await Task.Delay(1000);
                foreach (var key in _keyValueBooks.Keys)
                {                   
                    _keyValueBooks.AddOrUpdate(key, 1, (k, oldValue) => oldValue + 1);

                    if (_keyValueBooks.TryGetValue(key, out int value) && value >= 100)
                    {
                        _keyValueBooks.TryRemove(key, out _);
                        Console.WriteLine($"Книга '{key}' прочитана и удалена из списка.");
                    }
                }
            }
        }
    }
}
