using System;
using System.IO;
using System.Reflection;

namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn
{
    public class DevicesSchemeSetting
    {
        private static string _connectionString;

        public static bool InitializeDatabase { get; set; }

        public static string ConnectionString
        {
            get => _connectionString ?? throw new NullReferenceException($"{nameof(ConnectionString)} is not set");
            set => _connectionString = value;
        }

        public static readonly string DefaultConnectionString = Path.Combine(ExecutingAssemblyDirectory, "DevicesScheme.sdf");

        public static string ExecutingAssemblyDirectory
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                var filePath = assembly.CodeBase.Replace(@"file:///", string.Empty);

                return Path.GetDirectoryName(filePath);
            }
        }
    }
}