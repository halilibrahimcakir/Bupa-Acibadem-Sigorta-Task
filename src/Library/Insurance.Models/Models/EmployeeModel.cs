namespace Insurance.Models.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public decimal EMPLOYEETYPEID { get; set; }
        public decimal EMPLOYEEMANAGERID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PHONE { get; set; }
        public string ADRESS { get; set; }
        public string EMAIL { get; set; }
        public string TITLE { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
