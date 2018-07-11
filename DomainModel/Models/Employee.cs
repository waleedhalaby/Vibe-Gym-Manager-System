using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }
        public GenderEnum Gender { get; set; }
        public string Nationality { get; set; }
        public MaritalStatusEnum? MaritalStatus { get; set; }
        public int? NumberOfChilds { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Message { get; set; }

        public int TitleId { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        public Title Title { get; set; }
    }
}
