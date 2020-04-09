using System.Data.Entity.ModelConfiguration;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasOptional(p => p.DbDevice)
                .WithRequired(d => d.DbProduct);
        }
    }
}