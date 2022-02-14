namespace Insurance.Models.Models
{
    public class PolicyTypeModel
    {
        public int ID { get; set; }
        public decimal POLICYID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
