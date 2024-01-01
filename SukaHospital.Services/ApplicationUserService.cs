using sukaHospital.Repositories.Interfaces;
using SukaHospital.Models;
using SukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukaHospital.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private IUnitOfWork _unitOfWork;


        public ApplicationUserService(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public PagedResult<ApplicationUserViewModel> GetAll(int PageNumber, int PageSize)
        {
            var vm = new ApplicationUserViewModel();
            int totalCount;
            List<ApplicationUserViewModel> vmList = new List<ApplicationUserViewModel>();
            try
            {
                int ExcludeRecords = (PageSize * PageNumber) - PageSize;

                var modelList = _unitOfWork.GenericRepository<ApplicationUser>().GetAll()
            .Skip(ExcludeRecords).Take(PageSize).ToList();
                totalCount = _unitOfWork.GenericRepository<ApplicationUser>().GetAll().ToList().Count;
                vmList = ConvertModelToViewModelList(modelList);

            }
            catch (Exception)
            {
                throw;
            }

            var result = new PagedResult<ApplicationUserViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = PageNumber,
                PageSize = PageSize
            };
            return result;


        }

        public PagedResult<ApplicationUserViewModel> GetAllDoktor(int pageNumber, int pageSize)
        {
            var vm = new ApplicationUserViewModel();
            int totalCount;
            List<ApplicationUserViewModel> vmList = new List<ApplicationUserViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;

                var modelList = _unitOfWork.GenericRepository<ApplicationUser>().GetAll(x => x.IsDoktor == true)
            .Skip(ExcludeRecords).Take(pageSize).ToList();
                totalCount = _unitOfWork.GenericRepository<ApplicationUser>().GetAll(x => x.IsDoktor == true).ToList().Count;
                vmList = ConvertModelToViewModelList(modelList);

            }
            catch (Exception)
            {
                throw;
            }

            var result = new PagedResult<ApplicationUserViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        private List<ApplicationUserViewModel> ConvertModelToViewModelList(List<ApplicationUser> modelList)
        {
            return modelList.Select(x => new ApplicationUserViewModel(x)).ToList();
        }

        public PagedResult<ApplicationUserViewModel> GetAllHasta(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public PagedResult<ApplicationUserViewModel> SearchDoktor(int pageNumber, int pageSize, string Specialist = null)
        {
            throw new NotImplementedException();
        }

    } }
