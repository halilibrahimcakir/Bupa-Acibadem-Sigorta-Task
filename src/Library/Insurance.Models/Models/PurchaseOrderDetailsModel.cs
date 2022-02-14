namespace Insurance.Models.Models
{
    public class PurchaseOrderDetailsModel
    {
        public int ID { get; set; }
        public decimal PURCHASEORDERID { get; set; }
        public decimal INSUREDREGISTRATIONID { get; set; }
        public decimal PRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
        public decimal POLICYID { get; set; }
        public decimal POLICYTYPEID { get; set; }
        public decimal POLICYTYPEDETAILSID { get; set; }
    }
}
