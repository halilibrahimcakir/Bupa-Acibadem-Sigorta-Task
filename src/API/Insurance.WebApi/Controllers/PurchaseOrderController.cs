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
    public class PurchaseOrderController : Controller
    {
        private readonly IPurchaseOrderService _purchaseOrderService;
        public PurchaseOrderController(IPurchaseOrderService purchaseOrderService)
        {
            _purchaseOrderService = purchaseOrderService;
        }
        [HttpPost("Add")]
        public ResponseModel<PurchaseOrderModel> Add([FromBody] PurchaseOrderModel model)
        {
            try
            {
                return new ResponseModel<PurchaseOrderModel>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _purchaseOrderService.Add(model),
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<PurchaseOrderModel>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
    }
}
