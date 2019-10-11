using SQLData.Row;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.GiaoTac_Table
{
    public class GiaoTac : Row
    {
        [Key]
        public string MaSV { get; set; }
        [Ignore]
        public int[] Pass { get; set; }
        public GiaoTac() { }
        public GiaoTac(string MaSV, int Length)
        {
            this.MaSV = MaSV;
            Pass = new int[Length];
        }
        public new object[] GetFieldObjectArray()
        {
            List<object> propsToReturn = new List<object>();
            propsToReturn.Add(MaSV);
            foreach(int e in Pass)
            {
                propsToReturn.Add(e);
            }
            return propsToReturn.ToArray();
        }
    }
}
