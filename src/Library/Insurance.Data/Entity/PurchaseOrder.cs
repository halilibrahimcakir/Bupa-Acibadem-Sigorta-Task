namespace Insurance.Data.Entity
{
    public class PurchaseOrder
    {
        public int ID { get; set; }
        public int CUSTOMERID { get; set; }
        public int PAYMENTTYPEID { get; set; }
        public int INSTALLMENTAMOUNTID { get; set; }
        public decimal TOTALPRICE { get; set; }
        public string DESCRIPTION { get; set; }
        public int APPROVEREMPLOYEEID { get; set; }
        public int PURCHASEORDERSTATUSID { get; set; }
        public string EXPIRATIONDATE { get; set; }
        public int CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public int UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
