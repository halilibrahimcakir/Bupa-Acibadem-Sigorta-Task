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
    public class InsuredRegistrationService : IInsuredRegistarationService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<InsuredRegistration> _repository;

        public InsuredRegistrationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<InsuredRegistration>();
        }
        public InsuredRegistrationModel Add(InsuredRegistrationModel model)
        {
            try
            {
                List<InsuredRegistrationModel> insuredRegistrationList = new List<InsuredRegistrationModel>();
                insuredRegistrationList.AddRange(GetAll());
                var id = insuredRegistrationList.Select(x => x.ID).Max() + 1;
                var entity = LazyObject.Mapper.Map<InsuredRegistrationModel, InsuredRegistration>(model);
                var result = _repository.Add("SP_CREATE_INSUREDREGISTRATION", entity);
                model.ID = id;
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
                _repository.Delete("SP_DELETE_INSUREDREGISTRATION", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<InsuredRegistrationModel> GetAll()
        {
            try
            {
                List<InsuredRegistrationModel> list = new List<InsuredRegistrationModel>();

                var result = _repository.GetAll("SP_GETALL_INSUREDREGISTRATION");
                foreach (DataRow item in result.Rows)
                {
                    InsuredRegistrationModel insuredRegistrationModel = new InsuredRegistrationModel();

                    insuredRegistrationModel.ID = Convert.ToInt32(item["ID"]);
                    insuredRegistrationModel.CUSTOMERID = (decimal)item["CUSTOMERID"];
                    insuredRegistrationModel.PROXIMITYID = (decimal)item["PROXIMITYID"];
                    insuredRegistrationModel.NAME = item["NAME"].ToString();
                    insuredRegistrationModel.SURNAME = item["SURNAME"].ToString();
                    insuredRegistrationModel.NATIONALITY = item["NATIONALITY"].ToString();
                    insuredRegistrationModel.IDENTIFICATIONNUMBER = item["IDENTIFICATIONNUMBER"].ToString();
                    insuredRegistrationModel.BIRTHDATE = item["BIRTHDATE"].ToString();
                    insuredRegistrationModel.GENDER = item["GENDER"].ToString();
                    insuredRegistrationModel.EMAIL = item["EMAIL"].ToString();
                    insuredRegistrationModel.PHONE = item["PHONE"].ToString();
                    insuredRegistrationModel.CREATEBY = (decimal)item["CREATEBY"];
                    insuredRegistrationModel.CREATEDATE = item["CREATEDATE"].ToString();
                    insuredRegistrationModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    insuredRegistrationModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(insuredRegistrationModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public InsuredRegistrationModel GetById(int id)
        {
            try
            {

                InsuredRegistrationModel insuredRegistrationModel = new InsuredRegistrationModel();

                var result = _repository.GetById("SP_GETBYID_INSURANCEREGISTRATION", id);
                foreach (DataRow item in result.Rows)
                {
                    insuredRegistrationModel.ID = Convert.ToInt32(item["ID"]);
                    insuredRegistrationModel.CUSTOMERID = (int)item["CUSTOMERID"];
                    insuredRegistrationModel.PROXIMITYID = (int)item["PROXIMITYID"];
                    insuredRegistrationModel.NAME = item["NAME"].ToString();
                    insuredRegistrationModel.SURNAME = item["SURNAME"].ToString();
                    insuredRegistrationModel.NATIONALITY = item["NATIONALITY"].ToString();
                    insuredRegistrationModel.IDENTIFICATIONNUMBER = item["IDENTIFICATIONNUMBER"].ToString();
                    insuredRegistrationModel.BIRTHDATE = item["BIRTHDATE"].ToString();
                    insuredRegistrationModel.GENDER = item["GENDER"].ToString();
                    insuredRegistrationModel.EMAIL = item["EMAIL"].ToString();
                    insuredRegistrationModel.PHONE = item["PHONE"].ToString();
                    insuredRegistrationModel.CREATEBY = (int)item["CREATEBY"];
                    insuredRegistrationModel.CREATEDATE = item["CREATEDATE"].ToString();
                    insuredRegistrationModel.UPDATEBY = (int)item["UPDATEBY"];
                    insuredRegistrationModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                _unitOfWork.Dispose();
                return insuredRegistrationModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(InsuredRegistrationModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<InsuredRegistrationModel, InsuredRegistration>(model);
                var result = _repository.Update("SP_UPDATE_INSURANCEREGISTRATION", entity);
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