using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7_trpo
{
    public class Appointment
    {
        public string date { get; set; }
        public int doctor_id { get; set; }
        public string diagnosis { get; set; }
        public string recomendations { get; set; }
    }
}
