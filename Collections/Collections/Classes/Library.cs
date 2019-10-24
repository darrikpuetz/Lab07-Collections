using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[5];
        int count = 0; 

        public void Add(T item)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length * 2);
            }
            books[count] = item;
            count++;
        }
        public int CountBooks()
        {
            return count;
        }

        public void Remove(T book)
        {
            T[] removeCollection = books;
            int removeCount = count;
            books = new T[2];
            count = 0;
            for (int i = 0; i < removeCount; i++)
			{
                if (!temp[i].Equals(book))
                {
                    Add(temp[i]);
                }

			}
            if (count == removeCount)
            {
                throw new Exception("Book isn't there");
            }

        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
