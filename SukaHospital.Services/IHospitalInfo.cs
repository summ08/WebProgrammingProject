using sukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Services
{
    public interface IHospitalInfo
    {
        PagedResult<HospitalInfoViewModel> GetAll(int pageNumber, int pageSize);
        

        HospitalInfoViewModel GetHospitalById(int HospitalId);
        void UpdateHospitalInfo(HospitalInfoViewModel HospitalInfo);
        void DeleteHospitalInfo(int id);
        void InsertHospitalInfo(HospitalInfoViewModel HospitalInfo);




    }
}
