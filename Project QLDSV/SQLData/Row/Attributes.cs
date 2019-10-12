using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Row
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Key : Attribute
    {
        public string FeildName { get; set; }
        public Key() { }
        public Key(string FeildName) => this.FeildName = FeildName;
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class Ignore : Attribute
    {
        public Ignore() { }
    }
}
