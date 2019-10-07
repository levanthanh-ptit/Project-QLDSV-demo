using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Row
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Ignore : Attribute
    {
        public Ignore()
        {
        }
    }
}
