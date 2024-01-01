using SukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukaHospital.Services
{

    public interface IDoktorService
    {

        PagedResult<TimingViewModel> GetAll(int pageNumber, int pageSize);

        IEnumerable<TimingViewModel> GetAll();

        TimingViewModel GetTimingById(int TimingId);

        void UpdateTiming(TimingViewModel timing);

        void AddTiming(TimingViewModel timing);
        void DeleteTiming(int TimingId);

    }
}
