using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_2.models
{
    class Priems
    {
        public int id_Priem { get; set; }
        public int? id_Disease { get; set; }
        public int id_Schedule { get; set; }
        public int id_Patient { get; set; }
        public string prtim { get; set; }
        public string Disease { get; set; }

    }
}
