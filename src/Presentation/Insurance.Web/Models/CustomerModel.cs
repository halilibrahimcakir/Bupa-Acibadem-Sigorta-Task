using Newtonsoft.Json;
using System;

namespace Insurance.Web.Models
{
    public class CustomerModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        public string NAME { get; set; }
        [JsonProperty("surname")]
        public string SURNAME { get; set; }
        [JsonProperty("username")]
        public string USERNAME { get; set; }
        [JsonProperty("password")]
        public string PASSWORD { get; set; }
        [JsonProperty("nationality")]
        public string NATIONALITY { get; set; }
        [JsonProperty("Ididentificationnumber")]
        public string IDENTIFICATIONNUMBER { get; set; }
        [JsonProperty("birthdate")]
        public string BIRTHDATE { get; set; }
        [JsonProperty("gender")]
        public string GENDER { get; set; }
        [JsonProperty("email")]
        public string EMAIL { get; set; }
        [JsonProperty("phone")]
        public string PHONE { get; set; }
        [JsonProperty("adress")]
        public string ADRESS { get; set; }
        [JsonProperty("createdate")]
        public string CREATEDATE { get; set; }
        [JsonProperty("updatedate")]
        public string UPDATEDATE { get; set; }
        [JsonProperty("createby")]
        public decimal CREATEBY { get; set; }
        [JsonProperty("updateby")]
        public decimal UPDATEBY { get; set; }
    }
}
