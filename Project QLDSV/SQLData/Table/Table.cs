using System.Collections.Generic;
using System;
using SQLData.Table;

namespace SQLData.Table
{
    public abstract class Table<T> where T : Row.Row
    {
        public string TableName { get; }
        public T[] DataList { get; set; }
        public int CurrentIndex = -1;
        public T Current = null;
        public int Length = 0;
        private readonly int MaxLength;
        public TableState State = TableState.Initialized;
        public event EventHandler<RowEventArgs<T>> RowAdded;
        public event EventHandler<RowEventArgs<T>> RowDeleted;
        public event EventHandler<EventArgs> TableFilled;
        public Table(string tableName, int length = 100)
        {
            DataList = new T[length];
            MaxLength = length;
            TableName = tableName;
            AddEventHandler();
        }
        public void BeginRefill(int MaxLength)
        {
            DataList = new T[MaxLength];
            CurrentIndex = -1;
            Current = null;
            Length = 0;
        }
        public T DataAt(int index)
        {
            if (index < 0 || index >= MaxLength) return null;
            else return DataList[index];
        }

        public void MoveCurrentIndex(int index)
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
                if(row != null)
                if (ItemKeyCompare(item, row) == 0) return row;
            }
            return null;
        }

        public int FindIndex(T item) // còn cùi bắp. chặt nhị phân?
        {
            for (int i = 0; i < Length; i++)
            {
                if (DataList[i] != null)
                if (ItemKeyCompare(item, DataList[i]) == 0) return i;
            }
            return -1;
        }

        public void Add(T newItem)
        {
            if (FindIndex(newItem) == -1)
            {
                newItem.Index = Length;
                DataList[Length] = newItem;
                //Added event
                OnRowAdded(DataList[Length]);
                Length++;
                if (CurrentIndex == -1) MoveCurrentIndex(0);
            }
            else throw new PrimaryKeyException(PrimaryKeyException.DUPLICATED);
        }

        public void UpdateRow(T item)
        {
            DataList[item.Index] = item;
        }

        public void Remove(T item)
        {
            int index = FindIndex(item);
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
        public T[] Splice(int index, int deleteCount)
        {
            int endPoint = Length - deleteCount;
            for (int i = index; i < endPoint; i++)
            {
                DataList[i] = DataList[i + deleteCount];
                DataList[i].Index -= deleteCount;
            }
            T[] deleted = new T[deleteCount];
            for (int i = endPoint; i < Length; i++)
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
            State = TableState.Changed;
            RowAdded?.Invoke(this, new RowEventArgs<T>(t));
        }

        public void OnRowDeleted(T t)
        {
            State = TableState.Changed;
            RowDeleted?.Invoke(this, new RowEventArgs<T>(t));
        }
        public void OnTableFilled()
        {
            State = TableState.Filled;
            TableFilled?.Invoke(this, new EventArgs());
        }
    }
}
