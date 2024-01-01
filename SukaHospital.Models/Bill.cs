using SukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int BillNumber { get; set; }
        public Insurance Insurance { get; set; }
        public ApplicationUser Hasta { get; set; }
        public int DoktorCharge { get; set; }
        public int NoOfDays { get; set; }
        public int LabCharge{ get; set; }
        public int NursingCharge { get; set; }
        public decimal Advance { get; set; }
        public decimal OperationCharge { get; set; }
        public decimal RoomCharge { get; set; }

        public decimal TotalBill { get; set; }



    }
}
