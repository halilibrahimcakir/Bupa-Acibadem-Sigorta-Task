using Insurance.Models.Models;
using Insurance.Models.ResponseModel;
using Insurance.Services.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Insurance.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost("Add")]
        public ResponseModel<CustomerModel> Add([FromBody] CustomerModel model)
        {
            try
            {
                //if (!ModelState.IsValid)
                //{
                return new ResponseModel<CustomerModel>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _customerService.Add(model),
                    Message = "Succes"
                };
                //}
                //else
                //{
                //    return new ResponseModel<bool> { Data = false, Message = "Not valid model", StatusCode = StatusCodes.Status303SeeOther };
                //}
            }
            catch (Exception ex)
            {
                return new ResponseModel<CustomerModel>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
        [HttpDelete("Delete/{id}")]
        public ResponseModel<bool> Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return new ResponseModel<bool>
                    {
                        StatusCode = StatusCodes.Status200OK,
                        Data = _customerService.Delete(id),
                        Message = "Succes"
                    };
                }
                else
                {
                    return new ResponseModel<bool> { Message = "Model not valid", Data = false, StatusCode = StatusCodes.Status204NoContent };
                }
            }
            catch (Exception ex)
            {
                return new ResponseModel<bool>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = false,
                    Message = ex.Message
                };
            }
        }
        [HttpGet("GetAll")]
        public ResponseModel<List<CustomerModel>> GetAll()
        {
            try
            {
                return new ResponseModel<List<CustomerModel>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _customerService.GetAll(),
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<List<CustomerModel>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
        [HttpPost("GetById/{id}")]
        public ResponseModel<CustomerModel> GetById(int id)
        {
            try
            {
                return new ResponseModel<CustomerModel>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _customerService.GetById(id),
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<CustomerModel>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
        [HttpPut("Update")]
        public ResponseModel<bool> Update([FromBody] CustomerModel model)
        {

            try
            {
                return new ResponseModel<bool>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _customerService.Update(model),
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<bool>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = false,
                    Message = ex.Message
                };
            }
        }
    }
}
