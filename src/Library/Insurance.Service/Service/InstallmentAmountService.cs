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
    public class InstallmentAmountService : IInstallmentAmountService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<InstallmentAmount> _repository;

        public InstallmentAmountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<InstallmentAmount>();
        }
        public bool Add(InstallmentAmountModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<InstallmentAmountModel, InstallmentAmount>(model);
                var result = _repository.Add("SP_CREATE_INSTALLMENTAMOUNT", entity);
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
                _repository.Delete("SP_DELETE_INSTALLMENTAMOUNT", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<InstallmentAmountModel> GetAll()
        {
            try
            {
                List<InstallmentAmountModel> list = new List<InstallmentAmountModel>();

                var result = _repository.GetAll("SP_GETALL_INSTALLMENTAMOUNT");
                foreach (DataRow item in result.Rows)
                {
                    InstallmentAmountModel installmentAmountModel = new InstallmentAmountModel();

                    installmentAmountModel.ID = Convert.ToInt32(item["ID"]);
                    installmentAmountModel.AMOUNT = (int)item["USERNAME"];
                    installmentAmountModel.RAISE = (int)item["PASSWORD"];
                    installmentAmountModel.CREATEBY = (int)item["NATIONALITY"];
                    installmentAmountModel.CREATEDATE = item["IDENTIFICATIONNUMBER"].ToString();
                    installmentAmountModel.UPDATEBY = (int)item["BIRTHDATE"];
                    installmentAmountModel.UPDATEDATE = item["GENDER"].ToString();

                    list.Add(installmentAmountModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public InstallmentAmountModel GetById(int id)
        {
            try
            {
                InstallmentAmountModel installmentAmountModel = new InstallmentAmountModel();

                var result = _repository.GetById("SP_GETBYID_INSTALLMENTAMOUNT", id);
                foreach (DataRow item in result.Rows)
                {
                    installmentAmountModel.ID = Convert.ToInt32(item["ID"]);
                    installmentAmountModel.AMOUNT = (int)item["USERNAME"];
                    installmentAmountModel.RAISE = (int)item["PASSWORD"];
                    installmentAmountModel.CREATEBY = (int)item["NATIONALITY"];
                    installmentAmountModel.CREATEDATE = item["IDENTIFICATIONNUMBER"].ToString();
                    installmentAmountModel.UPDATEBY = (int)item["BIRTHDATE"];
                    installmentAmountModel.UPDATEDATE = item["GENDER"].ToString();
                }
                return installmentAmountModel;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(InstallmentAmountModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<InstallmentAmountModel, InstallmentAmount>(model);
                var result = _repository.Update("SP_UPDATE_INSTALLMENTAMOUNT", entity);
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