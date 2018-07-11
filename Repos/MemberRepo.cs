using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.RepoInterfaces;

namespace Repos
{
    public class MemberRepo : IMemberRepo
    {
        readonly string _connectionString;

        public MemberRepo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
