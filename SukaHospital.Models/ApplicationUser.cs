using Microsoft.AspNetCore.Identity;
using sukaHospital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukaHospital.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public Gender Gender{ get; set; }
        public string Nationality { get; set; }
        public string Adress { get; set; }
        public Gender Specialist { get; set; }

        public DateTime DOB { get; set; }
        public bool IsDoktor { get; set; }
        public string PictureUri { get; set; }
        public Department? Department { get; set; }
        [NotMapped]
        public ICollection<Appoinment> Appoinments { get; set; }
        [NotMapped]
        public ICollection<Payroll> Payrolls { get; set; }

    }

}


namespace SukaHospital.Models
    {


    public enum Gender
    {
        Male , Female , Other
    }
}

