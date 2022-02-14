using Insurance.Data.Entity;
using Insurance.Data.Repository;
using Insurance.Data.UnitOfWork;
using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public class PolicyTypeDetailsService : IPolicyTypeDetailsService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<PolicyTypeDetails> _repository;

        public PolicyTypeDetailsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<PolicyTypeDetails>();
        }
        public PolicyTypeDetailsService()
        {

        }
        public PolicyTypeDetailsModel GetById(int id)
        {
            try
            {
                PolicyTypeDetailsModel policyTypeDetailsModel = new PolicyTypeDetailsModel();

                var result = _repository.GetById("SP_GETBYID_PURCHASEORDERDETAILS", id);
                foreach (DataRow item in result.Rows)
                {
                    policyTypeDetailsModel.ID = Convert.ToInt32(item["ID"]);
                    policyTypeDetailsModel.POLICYTYPEID = (decimal)item["POLICYTYPEID"];
                    policyTypeDetailsModel.NAME = item["NAME"].ToString();
                    policyTypeDetailsModel.DESCRIPTION = item["DESCRIPTION"].ToString();
                    policyTypeDetailsModel.PRICE = (decimal)item["PRICE"];
                    policyTypeDetailsModel.CREATEBY = (decimal)item["CREATEBY"];
                    policyTypeDetailsModel.CREATEDATE = item["CREATEDATE"].ToString();
                    policyTypeDetailsModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    policyTypeDetailsModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                    policyTypeDetailsModel.PRIM = (decimal)item["PRIM"];
                }
                _unitOfWork.Dispose();
                return policyTypeDetailsModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
