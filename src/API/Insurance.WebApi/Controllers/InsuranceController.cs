using Insurance.Models.Models;
using Insurance.Models.ResponseModel;
using Insurance.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Insurance.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : Controller
    {
        private readonly IInsuredRegistarationService _insuredRegistarationService;
        public InsuranceController(IInsuredRegistarationService insuredRegistarationService)
        {
            _insuredRegistarationService = insuredRegistarationService;
        }
        [HttpPost("Add")]
        public ResponseModel<InsuredRegistrationModel> Add([FromBody] InsuredRegistrationModel model)
        {
            try
            {
                return new ResponseModel<InsuredRegistrationModel>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _insuredRegistarationService.Add(model),
                    Message = "Succes"
                };

            }
            catch (Exception ex)
            {
                return new ResponseModel<InsuredRegistrationModel>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
    }
}
