using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Insurance.Models.TokenModels
{
    public class TokenModel
    {
        [JsonIgnore]
        public EmployeeModel LoginUser { get; set; }
        public object AccessToken { get; set; }
    }
}
