namespace Insurance.Data.Entity
{
    public class InsuredRegistration
    {
        public int ID { get; set; }
        public decimal CUSTOMERID { get; set; }
        public decimal PROXIMITYID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string NATIONALITY { get; set; }
        public string IDENTIFICATIONNUMBER { get; set; }
        public string BIRTHDATE { get; set; }
        public string GENDER { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string ADRESS { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
