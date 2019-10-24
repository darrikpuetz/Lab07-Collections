using System;
using System.Collections.Generic;
using Collections.Classes;
namespace Collections
{
    public enum Genre
    {
        history,
        nonfiction,
        fiction,
        fantasy,
        action,
        dark
    }
    public class Program
    {

        public static Library<Books> NewLibrary = new Library<Books>();
        public static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            try
            {
                bool pickagain = true;
                while (pickagain)
                {
                    Console.WriteLine("Welcome to The Book Worm");
                    Console.WriteLine("Please choose an option. ");
                    Console.WriteLine("1) View books ");
                    Console.WriteLine("2) Add a book");
                    Console.WriteLine("3) Borrow a book");
                    Console.WriteLine("4) Return a book");
                    Console.WriteLine("5) View bookbag");
                    Console.WriteLine("6) Exit");

                    Int32.TryParse(Console.ReadLine(), out int option);

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine($"View Books. ");
                            ShowBooks();
                            break;
                        case 2:
                            Console.WriteLine("Adding a book. ");
                            AddABook("Yeet - The Lengend of Chris' Brain ", "Yettle", "McSkittles", Genre.fiction);
                            AddABook("Prodigy - The story of a young Korean man", "Kim", "Ae", Genre.fiction);
                            ShowBooks();
                            break;
                        case 3:
                            Console.WriteLine($"Borrowing a book. ");
                            break;
                        case 4:
                            Console.WriteLine("Return a book");
                            double subBalance = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine($"Counting books");
                            double depBalance = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
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
        public static void ShowBooks()
        {
            foreach(Books book1 in NewLibrary)
            {
                Console.WriteLine($"{book1.Title} is written by {book1.Author.FirstName} {book1.Author.LastName} and is part of {book1.Genre} genre. We have added this book to the library.");
            }
        }
        public static void AddABook(string title, string firstName, string lastName, Genre genre)
        {
            Books book = new Books()
            {
                Title = title,
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                Genre = genre
            };

            NewLibrary.Add(book);
            Console.WriteLine(book);
            return book;
        }

        //public static void ReturnBook()
        //{
        //    Dictionary<int, Books> books = new Dictionary<int, Books>();
        //    Console.WriteLine("Which book would you like to return");
        //    int counter = 1;
        //    foreach (var item in BookBag)
        //    {
        //        books.Add(counter, item);
        //        Console.WriteLine($"{counter++}. {item.Title} - {item.Author.FirstName} {item.Author.LastName}");

        //    }

        //    string response = Console.ReadLine();
        //    int.TryParse(response, out int selection);
        //    books.TryGetValue(selection, out Book returnedBook);
        //    BookBag.Remove(returnedBook);
        //    Library.Add(returnedBook);
        //}
    }
}
