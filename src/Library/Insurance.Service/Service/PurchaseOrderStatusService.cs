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
    public class PurchaseOrderStatusService : IPurchaseOrderStatusService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<PurchaseOrderStatus> _repository;

        public PurchaseOrderStatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<PurchaseOrderStatus>();
        }
        public bool Add(PurchaseOrderStatusModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PurchaseOrderStatusModel, PurchaseOrderStatus>(model);
                var result = _repository.Add("SP_CREATE_PURCHASEORDERSTATUS", entity);
                _unitOfWork.Dispose();
                return result;
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
                _repository.Delete("SP_DELETE_PURCHASEORDERSTATUS", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PurchaseOrderStatusModel> GetAll()
        {
            try
            {
                List<PurchaseOrderStatusModel> list = new List<PurchaseOrderStatusModel>();
                var result = _repository.GetAll("SP_GETALL_PURCHASEORDERSTATUS");
                foreach (DataRow item in result.Rows)
                {
                    PurchaseOrderStatusModel purchaseOrderStatusModel = new PurchaseOrderStatusModel();

                    purchaseOrderStatusModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderStatusModel.NAME = item["NAME"].ToString();
                    purchaseOrderStatusModel.CREATEBY = (int)item["CREATEBY"];
                    purchaseOrderStatusModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderStatusModel.UPDATEBY = (int)item["UPDATEBY"];
                    purchaseOrderStatusModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(purchaseOrderStatusModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PurchaseOrderStatusModel GetById(int id)
        {
            try
            {
                PurchaseOrderStatusModel purchaseOrderStatusModel = new PurchaseOrderStatusModel();

                var result = _repository.GetById("SP_GETBYID_PURCHASEORDERSTATUS", id);
                foreach (DataRow item in result.Rows)
                {
                    purchaseOrderStatusModel.ID = Convert.ToInt32(item["ID"]);
                    purchaseOrderStatusModel.NAME = item["NAME"].ToString();
                    purchaseOrderStatusModel.CREATEBY = (int)item["CREATEBY"];
                    purchaseOrderStatusModel.CREATEDATE = item["CREATEDATE"].ToString();
                    purchaseOrderStatusModel.UPDATEBY = (int)item["UPDATEBY"];
                    purchaseOrderStatusModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                _unitOfWork.Dispose();
                return purchaseOrderStatusModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PurchaseOrderStatusModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PurchaseOrderStatusModel, PurchaseOrderStatus>(model);
                var result = _repository.Update("SP_UPDATE_PURCHASEORDERSTATUS", entity);
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