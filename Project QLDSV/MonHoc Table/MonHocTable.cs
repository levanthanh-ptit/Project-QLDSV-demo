using SQLData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.Mon_Hoc
{
    public class MonHocTable : Table<MonHoc>
    {
        public MonHocTable(): base("MONHOC")
        {
        }
        public override int ItemKeyCompare(MonHoc t1, MonHoc t2)
        {
            return t1.MaMH.CompareTo(t2.MaMH);
        }

        protected override void AddEventHandler()
        {
           
        }
    }
}
