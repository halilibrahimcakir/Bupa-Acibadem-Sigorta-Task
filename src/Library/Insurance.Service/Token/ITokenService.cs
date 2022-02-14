using Insurance.Models.ResponseModel;
using Insurance.Models.TokenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Token
{
    public interface ITokenService
    {
        ResponseModel<TokenModel> Login(LoginModel login);

    }
}
