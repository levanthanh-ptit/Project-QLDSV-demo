using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLData;
namespace Project_QLDSV
{
    class DSSV : Table<Student>
    {
        public DSSV(long length) : base(length)
        {

        }
        public override bool ElementKeyCompare(Student t1, Student t2)
        {
            return t1.Name == t2.Name;
        }
    }
}
