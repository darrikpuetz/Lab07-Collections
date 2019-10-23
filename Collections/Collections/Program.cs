using System;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool pickagain = true;
                while (pickagain)
                {
                    Console.WriteLine("Welcome to The Book Worm");
                    Console.WriteLine("Please choose an option. ");
                    Console.WriteLine("1) Add Book ");
                    Console.WriteLine("2) Remove Books");
                    Console.WriteLine("3) Count Books");
                    Console.WriteLine("4) Exit");

                    Int32.TryParse(Console.ReadLine(), out int option);

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine($"Adding Books ");
                            break;
                        case 2:
                            Console.WriteLine("Removing Books");
                            double subBalance = Convert.ToInt32(Console.ReadLine());

                            break;
                        case 3:
                            Console.WriteLine($"Counting Books");
                            double depBalance = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine($"Exit");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.ReadKey();
                            break;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.Add(book);
        }

        public static void ReturnBook()
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            Console.WriteLine("Which book would you like to return");
            int counter = 1;
            foreach (var item in BookBag)
            {
                books.Add(counter, item);
                Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");

            }

            string response = Console.ReadLine();
            int.TryParse(response, out int selection);
            books.TryGetValue(selection, out Book returnedBook);
            BookBag.Remove(returnedBook);
            Library.Add(returnedBook);
        }
    }
}
