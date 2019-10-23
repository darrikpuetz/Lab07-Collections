using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] item = new T[5];
        int count;
        public int CountBooks()
        {
            return count;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return
            }
            throw new NotImplementedException();
        }
    }
}
