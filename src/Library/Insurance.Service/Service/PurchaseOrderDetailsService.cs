using Insurance.Data.Entity;
using Insurance.Data.Repository;
using Insurance.Data.UnitOfWork;
using Insurance.Models.Models;
using Insurance.Services.LazyInitialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public class PurchaseOrderDetailsService : IPurchaseOrderDetailsService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<PurchaseOrderDetails> _repository;

        public PurchaseOrderDetailsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<PurchaseOrderDetails>();
        }
        public PurchaseOrderDetailsModel Add(PurchaseOrderDetailsModel model)
        {
            try
            {
                List<PurchaseOrderDetailsModel> purchaseOrderDetailsList = new List<PurchaseOrderDetailsModel>();
                purchaseOrderDetailsList.AddRange(GetAll());
                var Id = purchaseOrderDetailsList.Select(x => x.ID).Max() + 1;
                var entity = LazyObject.Mapper.Map<PurchaseOrderDetailsModel, PurchaseOrderDetails>(model);
                var result = _repository.Add("SP_CREATE_PURCHASEORDERDETAILS", entity);
                model.ID = Id;
                _unitOfWork.Dispose();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _repository.Delete("SP_DELETE_PURCHASEORDERDETAILS", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PurchaseOrderDetailsModel> GetAll()
        {
            try
            {
                List<PurchaseOrderDetailsModel> list = new List<PurchaseOrderDetailsModel>();

                var result = _repository.GetAll("SP_GETALL_PURCHASEORDERDETAILS");
                foreach (DataRow item in result.Rows)
                {
                    PurchaseOrderDetailsModel purchaseOrderDetailsModel = new PurchaseOrderDetailsModel();

                    purchaseOrderDetailsModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderDetailsModel.PURCHASEORDERID = (decimal)item["PURCHASEORDERID"];
                    purchaseOrderDetailsModel.INSUREDREGISTRATIONID = (int)item["INSUREDREGISTRATIONID"];
                    purchaseOrderDetailsModel.PRICE = (decimal)item["PRICE"];
                    purchaseOrderDetailsModel.DESCRIPTION = item["DESCRIPTION"].ToString();
                    purchaseOrderDetailsModel.CREATEBY = (decimal)item["CREATEBY"];
                    purchaseOrderDetailsModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderDetailsModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    purchaseOrderDetailsModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                    purchaseOrderDetailsModel.POLICYID = (decimal)item["POLICYID"];
                    purchaseOrderDetailsModel.POLICYTYPEID = (decimal)item["POLICYTYPEID"];
                    purchaseOrderDetailsModel.POLICYTYPEDETAILSID = (decimal)item["POLICYTYPEDETAILSID"];

                    list.Add(purchaseOrderDetailsModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PurchaseOrderDetailsModel GetById(int id)
        {
            try
            {
                PurchaseOrderDetailsModel purchaseOrderDetailsModel = new PurchaseOrderDetailsModel();

                var result = _repository.GetById("SP_GETBYID_PURCHASEORDERDETAILS", id);
                foreach (DataRow item in result.Rows)
                {
                    purchaseOrderDetailsModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderDetailsModel.PURCHASEORDERID = (decimal)item["PURCHASEORDERID"];
                    purchaseOrderDetailsModel.INSUREDREGISTRATIONID = (int)item["INSUREDREGISTRATIONID"];
                    purchaseOrderDetailsModel.PRICE = (decimal)item["PRICE"];
                    purchaseOrderDetailsModel.DESCRIPTION = item["DESCRIPTION"].ToString();
                    purchaseOrderDetailsModel.CREATEBY = (decimal)item["CREATEBY"];
                    purchaseOrderDetailsModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderDetailsModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    purchaseOrderDetailsModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                    purchaseOrderDetailsModel.POLICYID = (decimal)item["POLICYID"];
                    purchaseOrderDetailsModel.POLICYTYPEID = (decimal)item["POLICYTYPEID"];
                    purchaseOrderDetailsModel.POLICYTYPEDETAILSID = (decimal)item["POLICYTYPEDETAILSID"];
                }
                _unitOfWork.Dispose();
                return purchaseOrderDetailsModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PurchaseOrderDetailsModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PurchaseOrderDetailsModel, PurchaseOrderDetails>(model);
                var result = _repository.Update("SP_UPDATE_PURCHASEORDERDETAILS", entity);
                _unitOfWork.Dispose();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}