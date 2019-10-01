using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV
{
    class Student
    {
        public string MASV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public Student() { }
        public Student(string MASV)
        {
            this.MASV = MASV;
        }
        public override string ToString()
        {
            return $"[MASV] {MASV}\n[HO] {HO}\n[TEN] {TEN}";
        }
    }
}
