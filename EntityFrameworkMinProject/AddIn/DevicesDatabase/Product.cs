namespace CoLa.BimEd.EntityFrameworkMinProject.AddIn.DevicesDatabase
{
    public class Product
    {
        public int Id { get; set; }
        public string PartNr { get; set; }
        public virtual Device DbDevice { get; set; }
    }
}