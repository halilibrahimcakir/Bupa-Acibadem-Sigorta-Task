namespace Insurance.Web.Models
{
    public class DiseaseInsuredMappingModel
    {
        public int ID { get; set; }
        public decimal INSUREDREGISTRATIONID { get; set; }
        public decimal DISEASEID { get; set; }
        public decimal CREATEBY { get; set; }
        public string CREATEDATE { get; set; }
        public decimal UPDATEBY { get; set; }
        public string UPDATEDATE { get; set; }
    }
}
