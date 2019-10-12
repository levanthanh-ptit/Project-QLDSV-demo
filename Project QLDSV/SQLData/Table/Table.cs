using System.Collections.Generic;
using System;
using SQLData.Table;

namespace SQLData.Table
{
    interface ITableEventInterface
    {
        void AddEventHandler();
    }
    public enum TableState
    {
        Initialized,
        Filled,
        Changed,
        Updated
    }
    public abstract class Table<T> : List<T> where T : Row.Row
    {
        public string TableName { get; }
        public TableState State = TableState.Initialized;
        public event EventHandler<RowEventArgs<T>> RowAdded;
        public event EventHandler<RowEventArgs<T>> RowDeleted;
        public event EventHandler<EventArgs> TableFilled;
        public Table(string tableName)
        {
            TableName = tableName;
            AddEventHandler();
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
            foreach (T row in this)
            {
                if (row != null)
                    if (ItemKeyCompare(item, row) == 0) return row;
            }
            return null;
        }
        public int FindIndex(T item) // còn cùi bắp. chặt nhị phân?
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (ItemKeyCompare(item, this[i]) == 0) return i;
            }
            return -1;
        }
        public new void Add(T newItem)
        {
            if (FindIndex(newItem) == -1)
            {
                base.Add(newItem);
            }
            else throw new PrimaryKeyException(PrimaryKeyException.DUPLICATED);
        }
        public void UpdateRow(T item)
        {
            this[item.Index] = item;
        }
        public new void Remove(T item)
        {
            int index = FindIndex(item);
            if (index == -1) return;
            T deleted = this[index];
            base.RemoveAt(index);
            //Deleted event
            OnRowDeleted(deleted);
        }
        /// <summary>
        /// less than 0 for left shift, greater than 0 for right shift.
        /// </summary>
        /// <param name="index">Position start</param>
        /// <param name="deleteCount">Delete item count</param>
        /// <returns>
        /// The deleted part
        /// </returns>
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
