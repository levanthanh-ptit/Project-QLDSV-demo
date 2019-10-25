using SQLData.Row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.Mon_Hoc
{
    public class MonHoc : Row
    {
        [Key]
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public MonHoc() { }
        public MonHoc(string maMH)
        {
            MaMH = maMH;
        }
        public new object[] GetFieldObjectArray()
        {
            List<object> feilds = new List<object>();
            feilds.Add(RowId);
            feilds.AddRange(base.GetFieldObjectArray());
            return feilds.ToArray();
        }
        
    }
}
