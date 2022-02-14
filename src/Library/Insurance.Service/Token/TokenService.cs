using Insurance.Models.TokenModels;
using Insurance.Models.ResponseModel;
using Insurance.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insurance.Models.Models;
using Insurance.Services.LazyInitialization;

namespace Insurance.Services.Token
{
    public class TokenService : ITokenService
    {
        IConfiguration _configuration;
        private readonly IEmployeeService _employeeService;

        public TokenService(IConfiguration configuration, IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            _configuration = configuration;
        }

        public ResponseModel<TokenModel> Login(LoginModel login)
        {
            var user = _employeeService.GetAll().Where(x => x.USERNAME == login.Username && x.PASSWORD == login.Password).FirstOrDefault();

            if (user != null)
            {
                var token = new TokenManagement(_configuration).CreateAccessToken(user);

                var userToken = new TokenModel()
                {
                    LoginUser = user,
                    AccessToken = token
                };

                return new ResponseModel<TokenModel>
                {
                    Message = "Token is success!",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new ResponseModel<TokenModel>
                {
                    Message = "UserCode or Password is wrong.",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
