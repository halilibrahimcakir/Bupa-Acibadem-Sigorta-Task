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
    public class PolicyService : IPolicyService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Policy> _repository;

        public PolicyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<Policy>();
        }
        public bool Add(PolicyModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PolicyModel, Policy>(model);
                var result = _repository.Add("SP_CREATE_POLICY", entity);
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
                _repository.Delete("SP_DELETE_POLICY", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PolicyModel> GetAll()
        {
            try
            {
                List<PolicyModel> list = new List<PolicyModel>();

                var result = _repository.GetAll("SP_GETALL_POLICY");
                foreach (DataRow item in result.Rows)
                {
                    PolicyModel policyModel = new PolicyModel();

                    policyModel.ID = Convert.ToInt32(item["ID"]);
                    policyModel.NAME = item["USERNAME"].ToString();
                    policyModel.DESCRIPTION = item["PASSWORD"].ToString();
                    policyModel.CREATEBY = (int)item["NATIONALITY"];
                    policyModel.CREATEDATE = item["IDENTIFICATIONNUMBER"].ToString();
                    policyModel.UPDATEBY = (int)item["BIRTHDATE"];
                    policyModel.UPDATEDATE = item["GENDER"].ToString();

                    list.Add(policyModel);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PolicyModel GetById(int id)
        {
            try
            {
                PolicyModel policyModel = new PolicyModel();

                var result = _repository.GetById("SP_GETBYID_POLICY", id);
                foreach (DataRow item in result.Rows)
                {
                    policyModel.ID = Convert.ToInt32(item["ID"]);
                    policyModel.NAME = item["USERNAME"].ToString();
                    policyModel.DESCRIPTION = item["PASSWORD"].ToString();
                    policyModel.CREATEBY = (int)item["NATIONALITY"];
                    policyModel.CREATEDATE = item["IDENTIFICATIONNUMBER"].ToString();
                    policyModel.UPDATEBY = (int)item["BIRTHDATE"];
                    policyModel.UPDATEDATE = item["GENDER"].ToString();
                }
                _unitOfWork.Dispose();
                return policyModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(PolicyModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<PolicyModel, Policy>(model);
                var result = _repository.Update("SP_UPDATE_POLICY", entity);
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