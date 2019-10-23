using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public enum Book
    {
        Invaders,
        Utopia,
        Gangsters,
        Solstice,
        Nations,
        Screams,
        Defenders,
        Signs,
        Mist,
        Guarding,
        Bandits,
        Trees
    }
    public enum Authors
    {
        Bob,
        Kara,
        Yeetle,
        Tommy,
        Billy
    }
    public enum Genre
    {
        Action,
        Fantasy,
        NonFiction,
        Fiction
    }

    public class Books
    {
        public Book BookTitle { get; set; }
        public Authors BookAuthor { get; set; }
        public Genre BookGenre { get; set; }


        public Books(Book title, Authors author, Genre genre)
        {
            BookTitle = title;
            BookAuthor = author;
            BookGenre = genre;

        }
    }
}
