using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int TrainerId { get; set; }
        public int PackageId { get; set; }
        public int FreezeTaken { get; set; }
        public int? FreezeRemaining { get; set; }
        public int SessionsTaken { get; set; }
        public int? SessionsRemaining { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public decimal? PaidAmount { get; set; }
        public bool Expired { get; set; }
        public bool Deleted { get; set; }
        public Employee Trainer { get; set; }
        public Member Member { get; set; }
        public Package Package { get; set; }
    }
}
