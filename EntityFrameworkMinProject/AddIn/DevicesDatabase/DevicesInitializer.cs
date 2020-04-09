using System.Data.Entity;
using System.Windows.Forms;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    public class DevicesInitializer : DropCreateDatabaseAlways<DevicesContext>
    {
        protected override void Seed(DevicesContext context)
        {
            MessageBox.Show($"DevicesInitializer.Seed({context})");
            
            CreateProduct(context);

            context.SaveChanges();

            base.Seed(context);
        }

        private static void CreateProduct(DevicesContext context)
        {
            var device = new Device
            {
                Id = 1,
                Name = "Device",
            };

            var product = new Product
            {
                Id = 1,
                PartNr = "0001",
                DbDevice =  device,
            };

            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}