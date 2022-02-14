using Insurance.Models.ResponseModel;
using Insurance.Models.TokenModels;
using Insurance.Services.Token;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Insurance.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenservice;
        public UserController(ITokenService tokenService)
        {
            _tokenservice = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        public ResponseModel<TokenModel> Login(LoginModel login)
        {
            try
            {
                return _tokenservice.Login(login);
            }
            catch (Exception ex)
            {
                return new ResponseModel<TokenModel>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
