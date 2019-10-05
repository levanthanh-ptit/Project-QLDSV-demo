using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLData.Row
{
    public abstract class Row
    {
        public int Index { get; set; }
        public long RowId { get; protected set; }
        private static long GlobalCurrentId = 1;

        public abstract override string ToString();

        public object[] ToRowObject() {
            PropertyInfo[] props = GetType().GetProperties();
            List<object> propsToReturn = new List<object>();
            foreach (PropertyInfo e in props)
            {
                if (e.CustomAttributes.Count() > 0)
                {
                    Key k = (Key)e.GetCustomAttribute(typeof(Key));
                    if (k.FeildName == null) k.FeildName = e.Name;
                }
                propsToReturn.Add(e.GetValue(this,null));
            }
            return propsToReturn.ToArray();
        }

        public long GetNewId()
        {
            return GlobalCurrentId++;
        }
       
    }
}
