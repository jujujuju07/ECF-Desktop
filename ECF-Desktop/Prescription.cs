using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_Desktop
{
    class Prescription
    {
        public int id { get; set; }
        public String liste_medicament { get; set; }
        public String posologie { get; set; }
        public String date_debut { get; set; }
        public String date_fin { get; set; }
        public int patient { get; set; }
    }
}
