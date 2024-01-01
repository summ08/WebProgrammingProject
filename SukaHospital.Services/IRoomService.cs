using sukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Services
{
    public interface IRoomService
    {
        PagedResult<RoomViewModel> GetAll(int pageNumber, int PageSize);

        RoomViewModel GetRoomById(int RoomId);

        void UpdateRoom(RoomViewModel Room);

        void DeleteRoom(int id);

        void InsertRoom(RoomViewModel Room);



    }
}
