using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Contract
    {
        public long Id { get; set; }
        public DateTime ContractDate { get; set; }
        public byte ContractType { get; set; }
        public byte PackageType { get; set; }
        public long MemberId { get; set; }
        public DateTime MembershipStarts { get; set; }
        public DateTime MembershipExpires { get; set; }
        public decimal MembershipFees { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountRemaining { get; set; }
        public long ReceiptNumber { get; set; }
        public DateTime AmountRemainingAt { get; set; }
        public byte PaymentMethod { get; set; }
        public string Notes { get; set; }

    }
}
