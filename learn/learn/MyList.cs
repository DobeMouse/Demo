using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class MyList<T> where T : IComparable
    {
        private T[] array;
        private int count = 0;

        public MyList()
        {
            array = new T[0];
        }
        public MyList(int size)
        {
            if (size >= 0)
            {
                array = new T[size];
            }
        }

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }
        public int Count
        {
            get { return count; }
        }
        private void kuorong()
        {
            if (Count == Capacity)
            {
                if (Capacity == 0)
                {
                    array = new T[4];
                }
                else
                {
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, Count);
                    array = newArray;
                }
            }
        }
        public bool indexExcption(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return true;
            }
            else
            {
                throw new Exception("索引超出范围");
            }
        }
        public void Add(T item)
        {
            kuorong();
            array[Count] = item;
            count++;
        }
        public T GetItem(int index)
        {
            indexExcption(index);
            return array[index];
        }
        public T this[int index]//索引器
        {
            get
            {
                return GetItem(index);
            }
            set
            {
                indexExcption(index);
                array[index] = value;
            }
        }
        public void Insert(int index, T item)
        {
            indexExcption(index);
            kuorong();
            for (int i = count - 1; i >= index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            indexExcption(index);
            for (int i = index + 1; i < count; i++)
            {
                array[i - 1] = array[i];
            }
            count--;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = count - 1; i >= 0; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Sort()
        {
            for (int j = 0; j < count - 1; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}
