using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPBD_2.models
{
    class Schedules
    {
        public int id_Schedule { get; set; }

        public int? Cabinet { get; set; }

        public int id_Doctor { get; set; }

        public DateTime time_Priem { get; set; }

        public bool free_flag { get; set; }

        public int? id_Patient { get; set; }
    }
}
