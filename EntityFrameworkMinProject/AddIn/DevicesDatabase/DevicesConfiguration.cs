using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.SqlServerCompact;
using System.Data.SqlServerCe;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    public class DevicesConfiguration : DbConfiguration
    {
        public DevicesConfiguration()
        {
            SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
            SetProviderServices(SqlCeProviderServices.ProviderInvariantName, SqlCeProviderServices.Instance);
            SetProviderFactory(SqlCeProviderServices.ProviderInvariantName, new SqlCeProviderFactory());
        }
    }
}