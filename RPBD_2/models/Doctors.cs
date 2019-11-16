using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_2.models
{
    class Doctors
    {
        public int id_Doctor { get; set; }

        public string FIO { get; set; }

        public int id_Special { get; set; }

        public int? numCabinet { get; set; }

        public string Specialty { get; set; }
    }
}
