using sukaHospital.ViewModels;
using sukaHospitals.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.Services
{
    public interface IContactService
    {


        PagedResult<ContactViewModel> GetAll(int pageNumber, int pageSize);


        ContactViewModel GetContactById(int ContactId);
        void UpdateContact(ContactViewModel contact);
        void DeleteContact(int id);
        void InsertContact(ContactViewModel contact);
    }
}
