using GoodsTracking.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsTracking.DataAccess
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private string _connectionString;

        public UnitOfWorkFactory(string connectionStringName)
        {
            _connectionString = ConfigurationManager.ConnectionStrings[connectionStringName]?.ConnectionString;
        }

        public IUnitOfWork CreateAutoCommit()
        {
            return new UnitOfWork(_connectionString, true);
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(_connectionString, false);
        }        
    }
}
