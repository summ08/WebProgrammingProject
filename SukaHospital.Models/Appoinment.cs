using SukaHospital.Models;

namespace sukaHospital.Models
{
    public class Appoinment
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public string Type { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser Doktor { get; set; }
        public ApplicationUser Hasta { get; set; }
        public string Description { get; set; }
            
    }
}