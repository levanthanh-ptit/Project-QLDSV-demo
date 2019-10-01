using System.Collections.Generic;
using System;
namespace SQLData
{
    abstract class Table<T> where T : class
    {
        public string TableName { get; }
        private T[] DataList;
        public long CurrentIndex;
        public T Current = null;
        public long Length = 0;
        private long MaxLength;
        public event EventHandler<RowEventArgs<T>> RowAdded;
        public event EventHandler<RowEventArgs<T>> RowDeleted;
        public Table(string tableName, long length = 100)
        {
            DataList = new T[length];
            MaxLength = length;
            CurrentIndex = -1;
            TableName = tableName;
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
        /// <summary>
        /// Key compare function
        /// <list type="int">
        /// <item>
        /// 0 : equare
        /// </item>
        /// <item>
        /// -1 : less than
        /// </item>
        /// <item>
        /// 1 : greeter than
        /// </item>
        /// </list>
        /// </summary>
        public abstract int ItemKeyCompare(T t1, T t2);
        public T Find(T item) // còn cùi bắp. chặt nhị phân?
        {
            foreach (T row in DataList)
            {
                if (ItemKeyCompare(item, row) == 0) return row;
            }
            return null;
        }
        public long FindIndex(T item) // còn cùi bắp. chặt nhị phân?
        {
            for (int i = 0; i < Length; i++)
            {
                if (ItemKeyCompare(item, DataList[i]) == 0) return i;
            }
            return -1;
        }
        public void Add(T newItem)
        {

            if (FindIndex(newItem) == -1)
            {
                DataList[Length] = newItem;
                //Added event
                OnRowAdded(DataList[Length]);
                Length++;
                if (CurrentIndex == -1) MoveCurrentIndex(0);
            }
            else throw new PrimaryKeyException(PrimaryKeyException.DUPLICATED);
        }
        public void Update(T item)
        {
            long index = FindIndex(item);
            DataList[index] = item;
        }
        public void Remove(T item)
        {
            long index = FindIndex(item);
            if (index == -1) return;
            T[] deleted = Splice(index, 1);
            //Deleted event
            OnRowDeleted(deleted[0]);
        }
        /// <summary>
        /// less than 0 for left shift, greater than 0 for right shift.
        /// </summary>
        /// <param name="index">Position start</param>
        /// <param name="deleteCount">Delete item count</param>
        /// <returns>
        /// The deleted part
        /// </returns>
        public T[] Splice(long index, long deleteCount)
        {
            long endPoint = index + deleteCount;
            if (endPoint > Length - deleteCount) endPoint = Length - deleteCount;
            for (long i = index; i < endPoint; i++)
            {
                DataList[i] = DataList[i + deleteCount];
            }
            T[] deleted = new T[deleteCount];
            for (long i = endPoint; i < Length; i++)
            {
                deleted[i - endPoint] = DataList[i];
                DataList[i] = null;
            }
            Length -= deleteCount;
            if (CurrentIndex >= Length) MoveCurrentIndex(Length - 1);
            return deleted;
        }
        protected abstract void AddEventHandler();
        public void OnRowAdded(T t)
        {
            RowAdded?.Invoke(this, new RowEventArgs<T>(t));
        }
        public void OnRowDeleted(T t)
        {
            RowDeleted?.Invoke(this, new RowEventArgs<T>(t));
        }
    }
}
