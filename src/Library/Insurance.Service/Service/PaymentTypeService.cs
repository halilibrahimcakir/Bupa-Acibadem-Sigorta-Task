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
    public class PaymentTypeService : IPaymentTypeService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<PaymentType> _repository;

        public PaymentTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<PaymentType>();
        }
        public bool Add(PaymentTypeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PaymentTypeModel, PaymentType>(model);
                var result = _repository.Add("SP_CREATE_PAYMENTTYPE", entity);
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
                _repository.Delete("SP_DELETE_PAYMENTTYPE", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PaymentTypeModel> GetAll()
        {
            try
            {
                List<PaymentTypeModel> list = new List<PaymentTypeModel>();

                var result = _repository.GetAll("SP_GETALL_PAYMENTTYPE");
                foreach (DataRow item in result.Rows)
                {
                    PaymentTypeModel paymentTypeModel = new PaymentTypeModel();

                    paymentTypeModel.ID = Convert.ToInt32(item["ID"]);
                    paymentTypeModel.NAME = item["NAME"].ToString();
                    paymentTypeModel.CREATEBY = (int)item["CREATEBY"];
                    paymentTypeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    paymentTypeModel.UPDATEBY = (int)item["UPDATEBY"];
                    paymentTypeModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(paymentTypeModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PaymentTypeModel GetById(int id)
        {
            try
            {
                PaymentTypeModel paymentTypeModel = new PaymentTypeModel();

                var result = _repository.GetById("SP_GETBYID_PAYMENTTYPE", id);
                foreach (DataRow item in result.Rows)
                {
                    paymentTypeModel.ID = Convert.ToInt32(item["ID"]);
                    paymentTypeModel.NAME = item["NAME"].ToString();
                    paymentTypeModel.CREATEBY = (int)item["CREATEBY"];
                    paymentTypeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    paymentTypeModel.UPDATEBY = (int)item["UPDATEBY"];
                    paymentTypeModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                return paymentTypeModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public bool Update(PaymentTypeModel model)
        {

            try
            {
                var entity = LazyObject.Mapper.Map<PaymentTypeModel, PaymentType>(model);
                var result = _repository.Update("SP_UPDATE_PAYMENTTYPE", entity);
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