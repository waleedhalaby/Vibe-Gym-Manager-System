using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class EmployeeAttendanceLog
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public DateTime SignIn { get; set; }
        public DateTime SignOut { get; set; }
    }
}
