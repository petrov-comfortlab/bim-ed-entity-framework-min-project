using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    [DbConfigurationType(typeof(DevicesConfiguration))]
    public class DevicesContext : DbContext
    {
        public DevicesContext() : base(DevicesSchemeSetting.ConnectionString)
        {
            if (DevicesSchemeSetting.InitializeDatabase)
                Database.SetInitializer(new DevicesInitializer());
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                var exceptionMessage = string.Concat(ex.Message, "The validation errors are: ", fullErrorMessage);

                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}