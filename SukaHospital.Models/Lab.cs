using SukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class Lab
    {
        public string Name { get; set; }
        public string LabNumber { get; set; }

        public ApplicationUser Hasta { get; set; }
          public int Id { get; set; }
        public string TestCode { get; set; }
        public string TestType{ get; set; }

        public int Weight { get; set; }
        public int Height { get; set; }

        public int BloodPressure { get; set; }
        public int Temperature { get; set; }

        public string TestResult { get; set; }

    }
}
