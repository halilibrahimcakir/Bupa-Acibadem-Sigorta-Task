using InsuranceWeb.UI.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceWeb.UI.Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //string conn = "User Id=INSURANCEDB;Password=test;Data Source=localhost:1521/ORCLPDB1.localdomain";
            //DataTable dt = new DataTable();

            //using (OracleConnection con = new OracleConnection(conn))
            //{
            //    using (OracleCommand cmd = new OracleCommand())
            //    {

            //        OracleParameter oracleParameter = new OracleParameter();
            //        oracleParameter.ParameterName = "RESULTS";
            //        oracleParameter.Direction = ParameterDirection.Output;
            //        oracleParameter.OracleDbType = OracleDbType.RefCursor;

            //        cmd.Connection = con;
            //        cmd.CommandText = "SP_CUSTOM_FORVIEW";
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add(oracleParameter);
            //        con.Open();
            //        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            //        adapter.Fill(dt);
            //        con.Close();
            //    }
            //}
            //List<CustomModel> list = new List<CustomModel>();

            //foreach (DataRow item in dt.Rows)
            //{
            //    CustomModel customModel = new CustomModel();

            //    customModel.CustomerName = item["CustomerName"].ToString();
            //    customModel.CustomerSurname = item["CustomerSurname"].ToString();
            //    customModel.InsuredName = item["InsuredName"].ToString();
            //    customModel.PolicyName = item["PolicyName"].ToString();
            //    customModel.PolicyPrice = item["PolicyPrice"].ToString();
            //    customModel.Prim = (decimal)item["Prim"];
            //    customModel.AmountCount = (decimal)item["AmountCount"];
            //    customModel.TotalPrice = (decimal)item["TotalPrice"];
            //    customModel.ApprovingName = item["ApprovingName"].ToString();
            //    customModel.PurchaseOrderStatusName = (decimal)item["PurchaseOrderStatusName"];


            //    list.Add(customModel);
            //}
            //var model = list;

            return View();
        }
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
