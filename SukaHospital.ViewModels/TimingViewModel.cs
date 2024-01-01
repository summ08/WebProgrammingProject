using sukaHospital.Models;
using SukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SukaHospital.ViewModels
{
    public class TimingViewModel
    {
        public int Id { get; set; }
        public DateTime ScheduleDate { get; set; }

        public int MorningShiftStartTime { get; set; }
        public int MorningShiftEndTime { get; set; }
        public int AfternoonShiftStartTime { get; set; }
        public int AfternoonShiftEndTime { get; set; }

        public int Duration { get; set; }

        public Status Status { get; set; }
        List<SelectListItem> morningShiftStart = new List<SelectListItem>();
        List<SelectListItem> morningShiftEnd = new List<SelectListItem>();
        List<SelectListItem> AfternoonShiftStart = new List<SelectListItem>();
        List<SelectListItem> AfternoonShiftEnd = new List<SelectListItem>();

        public ApplicationUser Doktor { get; set; }

        public TimingViewModel()
        {

        }

        public TimingViewModel(Timing model)
        { 
             Id=model.Id;
           ScheduleDate = model.ScheduleDate;
                 MorningShiftStartTime = model.MorningShiftStartTime;
                 MorningShiftEndTime = model.MorningShiftEndTime;
                 AfternoonShiftStartTime= model.AfternoonShiftStartTime;
                 AfternoonShiftEndTime= model.AfternoonShiftEndtime;
                 Duration = model.Duration;
                Status = model.Status;
                DoktorId = model.DoktorId;
            }


        public Timing ConvertViewModel(TimingViewModel model)
        {
            return new Timing
            {
                Id = model.Id,
                ScheduleDate = model.ScheduleDate,
                MorningShiftStartTime = model.MorningShiftStartTime,
                MorningShiftEndTime = model.MorningShiftEndTime,
                AfternoonShiftStartTime = model.AfternoonShiftStartTime,
                AfternoonShiftEndtime = model.AfternoonShiftEndTime,
                Duration = model.Duration,
                Status = model.Status,
                DoktorId = model.DoktorId,
            };
        }
    }
}

