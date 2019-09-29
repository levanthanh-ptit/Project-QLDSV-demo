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
        public long Length = 0;
        private long MaxLength;
        private long nextId = 0;
        public Table(long length)
        {
            DataList = new T[length];
            MaxLength = length;
        }

        public long GetNexId()
        {
            this.nextId++;
            return nextId;
        }
        public T DataAt(long index)
        {
            if (index < 0 || index >= MaxLength) return null;
            else return DataList[index];
        }
        public T RowAt(long index)
        {
            if (index < 0 || index >= Length) return null;
            else return DataList[index];
        }
        public abstract bool ElementCompare(T t1, T t2);
        public T First(T param)
        {
            foreach (T row in DataList)
            {
                if (ElementCompare(param, row)) return row;
            }
            return null;
        }
        public long FirstIndex(T param)
        {
            for (int i = 0; i < Length; i++)
            {
                if (ElementCompare(param, DataList[i])) return i;
            }
            return -1;
        }
        public void Add(T newElement)
        {
            if (FirstIndex(newElement) == -1) DataList[Length] = newElement;
        }
        public void remove(T element)
        {
            long index = FirstIndex(element);
            for(long i = index; i < Length -1; i++)
            {
                DataList[i] = DataList[i + 1];
            }
        }
    }
}
