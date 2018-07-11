using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.RepoInterfaces;

namespace DomainModel.APIs
{
    public class MemberApi
    {
        readonly string _connectionString;
        readonly IMemberRepo _memberRepo;
        public MemberApi(string connectionString, IMemberRepo memberRepo)
        {
            _connectionString = connectionString;
            _memberRepo = memberRepo;
        }
    }
}
