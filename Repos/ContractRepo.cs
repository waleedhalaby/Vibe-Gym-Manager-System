using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.RepoInterfaces;

namespace Repos
{
    public class ContractRepo : IContractRepo
    {
        readonly string _connectionString;

        public ContractRepo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
