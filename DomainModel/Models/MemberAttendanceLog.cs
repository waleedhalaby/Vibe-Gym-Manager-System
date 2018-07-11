using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class MemberAttendanceLog
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime SignIn { get; set; }
        public DateTime? SignOut { get; set; }
        public Member Member { get; set; }
    }
}
