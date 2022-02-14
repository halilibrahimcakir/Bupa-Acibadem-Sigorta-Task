using Insurance.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Insurance.Web.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var model = new CustomerModel();
            return View(model);
        }
        public async Task<IActionResult> SaveCustomer(CustomerModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:44301/api/customer/add", model);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    dynamic parseData = JsonConvert.DeserializeObject<dynamic>(result);

                    return Json(new { status = true, redirectUrl = Url.Action("InsuranceInformation", "Checkout", new { id = parseData.data.id }), System.Web.Mvc.JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
        public IActionResult InsuranceInformation(int id)
        {
            var model = new InsuredRegistrationModel();
            model.CUSTOMERID = id;
            return View(model);
        }
        public async Task<IActionResult> SaveInsurance(InsuredRegistrationModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:44301/api/insurance/add", model);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic parseData = JsonConvert.DeserializeObject<dynamic>(result);

                    return Json(new { status = true, redirectUrl = Url.Action("PurchaseInformation", "Checkout", new { customerid = model.CUSTOMERID, id = parseData.data.id }), System.Web.Mvc.JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }
        public IActionResult PurchaseInformation(decimal customerid, int id)
        {
            var model = new PurchaseOrderModel();
            model.CUSTOMERID = customerid;
            model.InsuredRegistrationId = id;
            return View(model);
        }
        public IActionResult SavePurchase(PurchaseOrderModel model)
        {
            return Json(new { status = true, redirectUrl = Url.Action("CheckoutCompleted", "Checkout", new { customerid = model.CUSTOMERID, paymenttypeid = model.PAYMENTTYPEID, insuredRegistrationId = model.InsuredRegistrationId, policyId = model.PolicyId }), System.Web.Mvc.JsonRequestBehavior.AllowGet });
        }


        public async Task<IActionResult> CheckoutCompleted(decimal customerid, decimal paymenttypeid, decimal insuredRegistrationId, decimal policyId)
        {
            PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
            purchaseOrderModel.CUSTOMERID = customerid;
            purchaseOrderModel.PAYMENTTYPEID = paymenttypeid;
            purchaseOrderModel.PURCHASEORDERSTATUSID = 2;
            purchaseOrderModel.APPROVEREMPLOYEEID = 0;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:44301/api/purchaseorder/add", purchaseOrderModel);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    dynamic parseData = JsonConvert.DeserializeObject<dynamic>(result);
                    PurchaseOrderDetailsModel purchaseOrderDetailsModel = new PurchaseOrderDetailsModel();
                    purchaseOrderDetailsModel.PURCHASEORDERID = parseData.data.id;
                    purchaseOrderDetailsModel.POLICYID = 1;
                    purchaseOrderDetailsModel.POLICYTYPEID = 1;
                    purchaseOrderDetailsModel.POLICYTYPEDETAILSID = policyId;
                    purchaseOrderDetailsModel.INSUREDREGISTRATIONID = insuredRegistrationId;
                    purchaseOrderDetailsModel.PRICE = 0;
                    HttpResponseMessage detailResponse = await client.PostAsJsonAsync("https://localhost:44301/api/purchaseorderdetails/add", purchaseOrderDetailsModel);
                }
            }
            return View();
        }

        public IActionResult test()
        {

            return View();
        }
    }
}
