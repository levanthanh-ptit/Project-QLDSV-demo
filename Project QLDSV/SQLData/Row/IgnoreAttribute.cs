using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.SQLData.Row
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Ignore : Attribute
    {
        public Ignore()
        {
        }
    }
}
