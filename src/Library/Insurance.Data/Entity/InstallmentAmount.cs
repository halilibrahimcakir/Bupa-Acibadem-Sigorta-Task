namespace Insurance.Data.Entity
{
    public class InstallmentAmount
    {
        public int ID { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal RAISE { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
