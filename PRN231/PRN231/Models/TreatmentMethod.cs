namespace PRN231.Models
{
    public class TreatmentMethod
    {
        public int treatID { get; set; }
        public int fertID { get; set; }
        public int medicineID { get; set; }
        public Treatment Treatment { get; set; }
        public Fertilizer Fertilizer { get; set; }
        public Medicine Medicine { get; set; }
    }
}
