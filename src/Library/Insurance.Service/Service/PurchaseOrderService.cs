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
    public class PurchaseOrderService : IPurchaseOrderService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<PurchaseOrder> _repository;

        public PurchaseOrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<PurchaseOrder>();
        }
        public PurchaseOrderModel Add(PurchaseOrderModel model)
        {
            try
            {
                List<PurchaseOrderModel> purchaseOrderList = new List<PurchaseOrderModel>();
                purchaseOrderList.AddRange(GetAll());
                var Id = purchaseOrderList.Select(x => x.ID).Max() + 1;
                var entity = LazyObject.Mapper.Map<PurchaseOrderModel, PurchaseOrder>(model);
                var result = _repository.Add("SP_CREATE_PURCHASEORDER", entity);
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
                _repository.Delete("SP_DELETE_PURCHASEORDER", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PurchaseOrderModel> GetAll()
        {
            try
            {
                List<PurchaseOrderModel> list = new List<PurchaseOrderModel>();

                var result = _repository.GetAll("SP_GETALL_PURCHASEORDER");
                foreach (DataRow item in result.Rows)
                {
                    PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();

                    purchaseOrderModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderModel.CUSTOMERID = (decimal)item["CUSTOMERID"];
                    purchaseOrderModel.PAYMENTTYPEID = (decimal)item["PAYMENTTYPEID"];
                    purchaseOrderModel.INSTALLMENTAMOUNTID = (decimal)item["INSTALLMENTAMOUNTID"];
                    purchaseOrderModel.TOTALPRICE = (decimal)item["TOTALPRICE"];
                    purchaseOrderModel.DESCRIPTION = item["DESCRIPTION"].ToString();
                    purchaseOrderModel.APPROVEREMPLOYEEID = (decimal)item["APPROVEREMPLOYEEID"];
                    purchaseOrderModel.PURCHASEORDERSTATUSID = (decimal)item["PURCHASEORDERSTATUSID"];
                    purchaseOrderModel.EXPIRATIONDATE = item["EXPIRATIONDATE"].ToString();
                    purchaseOrderModel.CREATEBY = (decimal)item["CREATEBY"];
                    purchaseOrderModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    purchaseOrderModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(purchaseOrderModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PurchaseOrderModel GetById(int id)
        {
            try
            {
                PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();

                var result = _repository.GetById("SP_GETBYID_PURCHASEORDER", id);
                foreach (DataRow item in result.Rows)
                {

                    purchaseOrderModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderModel.CUSTOMERID = (int)item["CUSTOMERID"];
                    purchaseOrderModel.PAYMENTTYPEID = (int)item["PAYMENTTYPEID"];
                    purchaseOrderModel.INSTALLMENTAMOUNTID = (int)item["INSTALLMENTAMOUNTID"];
                    purchaseOrderModel.TOTALPRICE = (decimal)item["TOTALPRICE"];
                    purchaseOrderModel.DESCRIPTION = item["DESCRIPTION"].ToString();
                    purchaseOrderModel.APPROVEREMPLOYEEID = (int)item["APPROVEREMPLOYEEID"];
                    purchaseOrderModel.PURCHASEORDERSTATUSID = (int)item["PURCHASEORDERSTATUSID"];
                    purchaseOrderModel.EXPIRATIONDATE = item["EXPIRATIONDATE"].ToString();
                    purchaseOrderModel.CREATEBY = (int)item["CREATEBY"];
                    purchaseOrderModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderModel.UPDATEBY = (int)item["UPDATEBY"];
                    purchaseOrderModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                _unitOfWork.Dispose();
                return purchaseOrderModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PurchaseOrderModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PurchaseOrderModel, PurchaseOrder>(model);
                var result = _repository.Update("SP_UPDATE_PURCHASEORDER", entity);
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