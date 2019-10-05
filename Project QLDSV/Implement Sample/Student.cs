using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLData.Row;

namespace Project_QLDSV
{
    class Student : Row
    {
        [Key]
        public string MASV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public Student() { }
        public Student(string MASV)
        {
            this.MASV = MASV;
        }
        public Student(int Index, string MASV, string HO, string TEN)
        {
            RowId = GetNewId();
            this.Index = Index;
            this.MASV = MASV;
            this.HO = HO;
            this.TEN = TEN;
        }
        public override string ToString()
        {
            return $"[MASV] {MASV} \n[HO] {HO} \n[TEN] {TEN}";
        }
    }
}
