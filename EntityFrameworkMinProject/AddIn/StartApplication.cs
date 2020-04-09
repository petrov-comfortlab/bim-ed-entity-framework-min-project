using System.Data.Entity;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn
{
    [Transaction(TransactionMode.Manual)]
    public class StartApplication : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            ConfigureEntityFramework();

            MessageBox.Show($"EntityFrameworkMinProject was started.");

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        private static void ConfigureEntityFramework()
        {
            DevicesSchemeSetting.InitializeDatabase = true;
            DevicesSchemeSetting.ConnectionString = DevicesSchemeSetting.DefaultConnectionString;
            DbConfiguration.LoadConfiguration(typeof(DevicesContext));
        }
    }
}
