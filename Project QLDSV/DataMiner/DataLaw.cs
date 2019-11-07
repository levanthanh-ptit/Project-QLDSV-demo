using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLDSV.DataMiner
{
    class DataLaw
    {
        public string Law { get; set; }
        public float minConf { get; set; }

        public DataLaw(string law, float minConf)
        {
            Law = law;
            this.minConf = minConf;
        }

        public DataLaw()
        {
        }
    }
}
