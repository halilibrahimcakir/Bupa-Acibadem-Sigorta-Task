namespace Insurance.Data.Entity
{
    public class PolicyTypeDetails
    {
        public int ID { get; set; }
        public decimal POLICYTYPEID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal PRICE { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
        public decimal PRIM { get; set; }
    }
}
