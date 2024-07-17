using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] arr;
        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
        public CustomList()
        {
            arr = new T[0];

        }
        public void Add(T item)
        {
            T[] TempArr = arr;
            arr = new T[arr.Length + 1];
            for (int i = 0; i < TempArr.Length; i++)
            {
                arr[i] = TempArr[i];
            }
            arr[arr.Length - 1] = item;
        }


        public T Find(T item)
        {
            return Array.Find(arr, x => x.Equals(item));
         

        }

        public T[] FindAll(T item)
        {
           

            return Array.FindAll(arr, x => x.Equals(item));
            
        }
        public void RemoveAll()
        {
            arr = new T[0];
        }
        public void Remove(T item)
        {
            bool k = false;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    index = i;
                    k = true;
                }
            }

            if (k)
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
            else
            {
                Console.WriteLine("tapilmadi");
            }
        }

        public int count()
        {
            return Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in arr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
