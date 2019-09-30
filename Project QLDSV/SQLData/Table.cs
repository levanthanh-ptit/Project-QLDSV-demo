using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    abstract class Table<T> where T : class
    {
        private T[] DataList;
        public long CurrentIndex;
        public T Current = null;
        public long Length = 0;
        private long MaxLength;
        public Table(long length)
        {
            DataList = new T[length];
            MaxLength = length;
            CurrentIndex = -1;
        }

        public T DataAt(long index)
        {
            if (index < 0 || index >= MaxLength) return null;
            else return DataList[index];
        }
        public void MoveCurrentIndex(long index)
        {
            CurrentIndex = index;
            Current = DataList[index];
        }
        public void MoveNext()
        {
            if (DataList[CurrentIndex + 1] != null)
            {
                MoveCurrentIndex(++CurrentIndex);
            }
        }
        public void MovePrevious()
        {
            if (CurrentIndex - 1 >= 0)
            {
                MoveCurrentIndex(--CurrentIndex);
            }
        }
        public abstract bool ElementKeyCompare(T t1, T t2);
        public T Find(T param)
        {
            foreach (T row in DataList)
            {
                if (ElementKeyCompare(param, row)) return row;
            }
            return null;
        }
        public long FindIndex(T element)
        {
            for (int i = 0; i < Length; i++)
            {
                if (ElementKeyCompare(element, DataList[i])) return i;
            }
            return -1;
        }
        public void Add(T newElement)
        {

            if (FindIndex(newElement) == -1)
            {
                DataList[Length] = newElement;
                Length++;
                if (CurrentIndex == -1) MoveCurrentIndex(0);
            }
        }
        public void Update(T element)
        {
            long index = FindIndex(element);
            DataList[index] = element;
        }
        public void Remove(T element)
        {
            long index = FindIndex(element);
            if (index == -1) return;
            for (long i = index; i < Length - 1; i++)
            {
                DataList[i] = DataList[i + 1];
            }
            DataList[Length - 1] = null;
            Length--;
            if (CurrentIndex >= Length) MoveCurrentIndex(Length - 1);
        }
    }
}
