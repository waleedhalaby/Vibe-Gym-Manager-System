using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class EmployeeAttendanceLog
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SignIn { get; set; }
        public string SignInMessage { get; set; }
        public DateTime? SignOut { get; set; }
        public string SignOutMessage { get; set; }
        public Employee Employee { get; set; }

    }
}
