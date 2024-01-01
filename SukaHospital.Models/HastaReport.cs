using SukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class HastaReport
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public ApplicationUser Doktor { get; set; }
        public ApplicationUser Hasta { get; set; }

        public ICollection<PrescribedMedicine> PrescribedMedicine{ get; set; }

    }
}
