using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Member
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string EmergencyNumber { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public byte MaritalStatus { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string CompanyAddress { get; set; }
        public string ImageUrl { get; set; }
    }
}
