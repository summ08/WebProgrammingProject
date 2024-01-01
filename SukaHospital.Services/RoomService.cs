using sukaHospital.Models;
using sukaHospital.Repositories.Interfaces;
using sukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Services
{
    public class RoomService : IRoomService
    {
        private IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void DeleteRoom(int id)
        {

            var model = _unitOfWork.GenericRepository<Room>().GetById(id);
            _unitOfWork.GenericRepository<Room>().Delete(model);
            _unitOfWork.Save();
        }

        public PagedResult<RoomViewModel> GetAll(int pageNumber, int pageSize)
        {
            var vm= new RoomViewModel();
            int totalCount;
            List<RoomViewModel> vmList = new List<RoomViewModel>();
            try
            {
                int ExcludeRecords = (pageSize*pageNumber) -pageSize;

                var modelList =_unitOfWork.GenericRepository<Room>().GetAll(includeProperties:"Hospital")
                    .Skip(ExcludeRecords).Take(pageSize).ToList();

                totalCount=_unitOfWork.GenericRepository<Room>().GetAll().ToList().Count;

                vmList = ConvertModelToViewModelList(modelList);
            }

            catch (Exception)
            {
                throw;
            }

            var result = new PagedResult<RoomViewModel>
            {
                Data = vmList,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = totalCount

            };

            return result;

        }


        public RoomViewModel GetHospitalById(int HospitalId)
        {

            var model = _unitOfWork.GenericRepository<Room>().GetById(HospitalId);
            var vm = new RoomViewModel(model);
            return vm;

        }

        public RoomViewModel GetRoomById(int RoomId)
        {
            throw new NotImplementedException();
        }

        public void InsertRoom(RoomViewModel Room)
        {
            var model = new RoomViewModel().ConvertViewModel(Room);
            _unitOfWork.GenericRepository<Room>().Add(model);
            _unitOfWork.Save() ;
        }

        public void UpdateRoom(RoomViewModel Room)
        {
            var model = new RoomViewModel().ConvertViewModel(Room);
           var ModelById=_unitOfWork.GenericRepository<Room>().GetById(model.Id);
            ModelById.Type=Room.Type;
            ModelById.Status=Room.Status;
            ModelById.RoomNumber=Room.RoomNumber;
            ModelById.HospitalId = Room.HospitalInfoId;
            _unitOfWork.GenericRepository<Room>().Update(ModelById);
            _unitOfWork.Save();
        }

        private List<RoomViewModel> ConvertModelToViewModelList(List<Room> modelList)
        {
            return modelList.Select(x=> new RoomViewModel(x)).ToList();
        }
    }
}
