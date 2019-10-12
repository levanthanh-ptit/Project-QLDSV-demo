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
        public object this[int index]
        {
            get
            {
                if (index == 0) return MaSV;
                else return Pass[index - 1];
            }
            set
            {
                if (index == 0) MaSV = (string)value;
                else Pass[index - 1] = (int)value;
            }
        }
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
            foreach (int e in Pass)
                if (e != -1) propsToReturn.Add(e);
                else propsToReturn.Add("Không thi");
            return propsToReturn.ToArray();
        }
    }
}
