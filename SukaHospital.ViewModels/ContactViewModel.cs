using sukaHospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sukaHospital.ViewModels
{
    public class ContactViewModel
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public int HospitalInfoId { get; set; }
        public int Id { get; set; }


        public ContactViewModel()
        {

        }

        public ContactViewModel(Contact model)
        {

            Email = model.Email;
            Phone = model.Phone;
            HospitalInfoId = model.HospitalId;
            Id = model.Id;

        }
         public Contact ConvertViewModel(ContactViewModel model)
        {
            return new Contact
            {
                Email = model.Email,
                Phone = model.Phone,
                HospitalId = model.HospitalInfoId,
                Id = model.Id
            };
        }

    }
}
