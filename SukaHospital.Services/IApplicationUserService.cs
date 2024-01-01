using SukaHospital.ViewModels;
using sukaHospitals.Utilities;

namespace SukaHospital.Services
{
    public interface IApplicationUserService
    {
        PagedResult<ApplicationUserViewModel> GetAll(int pageNumber, int pageSize);
        PagedResult<ApplicationUserViewModel> GetAllDoktor(int pageNumber, int pageSize);
        PagedResult<ApplicationUserViewModel> GetAllHasta(int pageNumber, int pageSize);
        PagedResult<ApplicationUserViewModel> SearchDoktor(int pageNumber, int pageSize , string Specialist=null);
    }
}