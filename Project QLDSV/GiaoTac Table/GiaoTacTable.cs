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
        public GiaoTacTable() : base("GiaoTac")
        {
        }
        public override int ItemKeyCompare(GiaoTac t1, GiaoTac t2)
        {
            return t1.MaSV.CompareTo(t2.MaSV);
        }

        protected override void AddEventHandler()
        {

        }

        public List<object[]> EndcodeList()
        {
            List<object[]> list = new List<object[]>();
            for (int i = 0; i < DynamicFeildLabels.Count; i++)
            {
                list.Add(new object[] { DynamicFeildLabels[i], i + 1 });
            }
            return list;
        }
    }
}
