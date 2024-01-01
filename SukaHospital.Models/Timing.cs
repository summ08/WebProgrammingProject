
using SukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Models
{
    public class Timing
    {

        public int Id { get; set; }
        public Guid DoktorId { get; set; }

        public ApplicationUser Doktor { get; set; }
        public DateTime ScheduleDate {get; set; }

    public int MorningShiftStartTime { get; set; }
    public int MorningShiftEndTime { get; set; }
    public int AfternoonShiftStartTime { get; set; }
    public int AfternoonShiftEndtime { get; set; } 

    public int Duration { get; set;}

        public Status Status { get; set;}

            } 
}

namespace sukaHospital.Models
{
    public enum Status
    {
        Available, Pending, Confirm

    }
}