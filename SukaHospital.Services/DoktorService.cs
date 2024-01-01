using sukaHospital.Models;
using sukaHospital.Repositories.Interfaces;
using SukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukaHospital.Services
{
    public class DoktorService :IDoktorService
    {
        private IUnitOfWork _unitOfWork;

        public DoktorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
         

        public void AddTiming(TimingViewModel timing)
        {

            var model = _unitOfWork.GenericRepository<Timing>().GetById(TimingId);
            _unitOfWork.GenericRepository<Timing>().Add(model);
            _unitOfWork.Save();
        }
        public void DeleteTiming(int TiminId)
        {

            var model = _unitOfWork.GenericRepository<Timing>().GetById(TimingId);
            _unitOfWork.GenericRepository<Timing>().Delete(model);
            _unitOfWork.Save();
        }

        public PagedResult<TimingViewModel> GetAll(int pageNumber, int pageSize)
        {
            var vm = new TimingViewModel();
            int totalCount;
            List<TimingViewModel> vmList = new List<TimingViewModel>();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;

                var TimingList = _unitOfWork.GenericRepository<Timing>().GetAll(includeProperties: "Hospital")
                    .Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount = _unitOfWork.GenericRepository<Timing>().GetAll().ToList().Count;

                vmList = ConvertModelToViewModelList(TimingList);
            }

            catch (Exception)
            {
                throw;
            }

            var result = new PagedResult<TimingViewModel>
            {
                Data = vmList,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = totalCount

            };

            return result;

        }


        public IEnumerable<TimingViewModel> GetAll()
        {
            var TimingList=_unitOfWork.GenericRepository<Timing>().GetAll().ToList();
            var vmList = ConvertModelToViewModel(TimingList);
                return vmList;



        }
        public TimingViewModel GetTimingById(int TimingId)
        {

            var model = _unitOfWork.GenericRepository<Timing>().GetById(TimingId);
            var vm = new TimingViewModel(model);
            return vm;

        }

        private List<TimingViewModel>  ConvertModelToViewModelList(List<Timing> modelList)
        {
            return modelList.Select(x => new TimingViewModel(x)).ToList();  
        }

        public void UpdateTiming(TimingViewModel timing)
        {
            var model = new TimingViewModel().ConvertViewModel(timing);
            var ModelById = _unitOfWork.GenericRepository<Timing>().GetById(model.Id);
            ModelById.Id = timing.Id;
            ModelById.Status = timing.Status;
            ModelById.Duration = timing.Duration;
            ModelById.DoktorId = timing.DoktorId;
            ModelById.AfternoonShiftEndtime = timing.AfternoonShiftEndTime;
            ModelById.AfternoonShiftStartTime = timing.AfternoonShiftStartTime;
            ModelById.MorningShiftStartTime= timing.MorningShiftStartTime;
            ModelById.MorningShiftEndTime= timing.MorningShiftEndTime;
            _unitOfWork.GenericRepository<Timing>().Update(ModelById);
            _unitOfWork.Save();
        }

    }
    }
}
