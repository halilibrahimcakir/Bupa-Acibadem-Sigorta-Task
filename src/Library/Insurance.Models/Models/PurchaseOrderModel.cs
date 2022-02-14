namespace Insurance.Models.Models
{
    public class PurchaseOrderModel
    {
        public int ID { get; set; }
        public decimal CUSTOMERID { get; set; }
        public decimal PAYMENTTYPEID { get; set; }
        public decimal INSTALLMENTAMOUNTID { get; set; }
        public decimal TOTALPRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal APPROVEREMPLOYEEID { get; set; }
        public decimal PURCHASEORDERSTATUSID { get; set; }
        public string EXPIRATIONDATE { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
