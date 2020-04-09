namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Product DbProduct { get; set; }
    }
}