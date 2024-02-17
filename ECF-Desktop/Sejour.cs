using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_Desktop
{
    class Sejour
    {
        public int id { get; set; }
        public String date { get; set; }
        public String motif { get; set; }
        public String specialite { get; set; }
        public int entre { get; set; }
        public int sortie { get; set; }
        public int medecin { get; set; }
        public int patient { get; set; }
    }
}
