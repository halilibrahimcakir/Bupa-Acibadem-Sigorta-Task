using System.Text.Json.Serialization;

namespace Insurance.Web.Models
{
    public class ResponseModel
    {
        [JsonPropertyName("message")]
        public string Message;

        [JsonPropertyName("statusCode")]
        public int StatusCode;

        [JsonPropertyName("data")]
        public Data Data;
    }

    public class Data
    {
        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("surname")]
        public string Surname;

        [JsonPropertyName("username")]
        public string Username;

        [JsonPropertyName("password")]
        public string Password;

        [JsonPropertyName("nationality")]
        public string Nationality;

        [JsonPropertyName("identificationnumber")]
        public string Identificationnumber;

        [JsonPropertyName("birthdate")]
        public string Birthdate;

        [JsonPropertyName("gender")]
        public string Gender;

        [JsonPropertyName("email")]
        public string Email;

        [JsonPropertyName("phone")]
        public string Phone;

        [JsonPropertyName("adress")]
        public string Adress;

        [JsonPropertyName("createdate")]
        public string Createdate;

        [JsonPropertyName("updatedate")]
        public string Updatedate;

        [JsonPropertyName("createby")]
        public int Createby;

        [JsonPropertyName("updateby")]
        public int Updateby;
    }
}
