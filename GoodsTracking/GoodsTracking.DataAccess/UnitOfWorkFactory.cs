using GoodsTracking.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.DataAccess
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private string _connectionString;

        public UnitOfWorkFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_connectionString);
        }
    }
}
