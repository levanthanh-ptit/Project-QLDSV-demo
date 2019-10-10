using SQLData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.GiaoTac_Table
{
    public class GiaoTacTable : PivotTable<GiaoTac>
    {
        public GiaoTacTable(int length = 100) : base("GiaoTac", length)
        {
        }

        public override int ItemKeyCompare(GiaoTac t1, GiaoTac t2)
        {
            return t1.MaSV.CompareTo(t2.MaSV);
        }

        protected override void AddEventHandler()
        {
            
        }
    }
}
