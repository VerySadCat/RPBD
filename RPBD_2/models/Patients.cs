using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_2.models
{
    class Patients
    {
        public int id_Patient { get; set; }
        public string passport { get; set; }

        public string FIO { get; set; }

        public string address { get; set; }

        public string telefon { get; set; }

        public int id_Stat { get; set; }

        public string StatPatient { get; set; }

    }
}
