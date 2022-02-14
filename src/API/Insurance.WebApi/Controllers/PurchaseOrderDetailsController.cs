using Insurance.Models.Models;
using Insurance.Models.ResponseModel;
using Insurance.Services.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Insurance.WebApi.Controllers
{
    public class PurchaseOrderDetailsController : Controller
    {
        private readonly IPurchaseOrderDetailsService _purchaseOrderDetailsService;
        private readonly IPolicyTypeDetailsService _policyTypeDetailsService;
        private readonly IPurchaseOrderService _purchaseOrderService;
        private readonly IPaymentTypeService _paymentTypeService;

        public PurchaseOrderDetailsController(IPurchaseOrderDetailsService purchaseOrderDetailsService, IPolicyTypeDetailsService policyTypeDetailsService, IPurchaseOrderService purchaseOrderService, IPaymentTypeService paymentTypeService)
        {
            _purchaseOrderDetailsService = purchaseOrderDetailsService;
            _policyTypeDetailsService = policyTypeDetailsService;
            _purchaseOrderService = purchaseOrderService;
            _paymentTypeService = paymentTypeService;
        }
        [HttpPost("Add")]
        public ResponseModel<PurchaseOrderDetailsModel> Add([FromBody] PurchaseOrderDetailsModel model)
        {
            try
            {
                var policyPrice = _policyTypeDetailsService.GetById((int)model.POLICYTYPEDETAILSID).PRICE;

                var order = _purchaseOrderService.GetById((int)model.PURCHASEORDERID);

                var paymentType = _paymentTypeService.GetById((int)order.PAYMENTTYPEID);

                model.PRICE = ((policyPrice / 100) * -paymentType.DISCOUNT) + policyPrice;

                PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
                purchaseOrderModel.ID = order.ID;
                purchaseOrderModel.CUSTOMERID = order.CUSTOMERID;
                purchaseOrderModel.PAYMENTTYPEID = order.PAYMENTTYPEID;
                purchaseOrderModel.INSTALLMENTAMOUNTID = order.INSTALLMENTAMOUNTID;
                purchaseOrderModel.TOTALPRICE = order.TOTALPRICE + model.PRICE;
                purchaseOrderModel.DESCRIPTION = order.DESCRIPTION;
                purchaseOrderModel.APPROVEREMPLOYEEID = order.APPROVEREMPLOYEEID;
                purchaseOrderModel.PURCHASEORDERSTATUSID = order.PURCHASEORDERSTATUSID;
                purchaseOrderModel.EXPIRATIONDATE = order.EXPIRATIONDATE;
                purchaseOrderModel.CREATEBY = order.CREATEBY;
                purchaseOrderModel.CREATEDATE = order.CREATEDATE;
                purchaseOrderModel.UPDATEBY = order.UPDATEBY;
                purchaseOrderModel.UPDATEDATE = order.UPDATEDATE;

                _purchaseOrderService.Update(purchaseOrderModel);

                return new ResponseModel<PurchaseOrderDetailsModel>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Data = _purchaseOrderDetailsService.Add(model),
                    Message = "Succes"
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel<PurchaseOrderDetailsModel>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null,
                    Message = ex.Message
                };
            }
        }
    }
}
