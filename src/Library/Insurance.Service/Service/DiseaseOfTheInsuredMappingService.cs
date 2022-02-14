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
    public class DiseaseOfTheInsuredMappingService : IDiseaseOfTheInsuredMappingService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<DiseaseOfTheInsuredMapping> _repository;

        public DiseaseOfTheInsuredMappingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<DiseaseOfTheInsuredMapping>();
        }
        public bool Add(DiseaseOfTheInsuredMappingModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<DiseaseOfTheInsuredMappingModel, DiseaseOfTheInsuredMapping>(model);
                var result = _repository.Add("SP_CREATE_DISEASEOFTHEINSUREDMAPPING", entity);
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
                _repository.Delete("SP_DELETE_DISEASEOFTHEINSUREDMAPPING", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiseaseOfTheInsuredMappingModel> GetAll()
        {
            try
            {
                List<DiseaseOfTheInsuredMappingModel> list = new List<DiseaseOfTheInsuredMappingModel>();

                var result = _repository.GetAll("SP_GETALL_DISEASEOFTHEINSUREDMAPPING");
                foreach (DataRow item in result.Rows)
                {
                    DiseaseOfTheInsuredMappingModel diseaseOfTheInsuredMappingModel = new DiseaseOfTheInsuredMappingModel();

                    diseaseOfTheInsuredMappingModel.ID = Convert.ToInt32(item["ID"]);
                    diseaseOfTheInsuredMappingModel.INSUREDREGISTRATIONID = (int)item["INSUREDREGISTRATIONID"];
                    diseaseOfTheInsuredMappingModel.DISEASEID = (int)item["DISEASEID"];
                    diseaseOfTheInsuredMappingModel.CREATEBY = (decimal)item["CREATEBY"];
                    diseaseOfTheInsuredMappingModel.CREATEDATE = item["CREATEDATE"].ToString();
                    diseaseOfTheInsuredMappingModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    diseaseOfTheInsuredMappingModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(diseaseOfTheInsuredMappingModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DiseaseOfTheInsuredMappingModel GetById(int id)
        {
            try
            {
                DiseaseOfTheInsuredMappingModel diseaseOfTheInsuredMappingModel = new DiseaseOfTheInsuredMappingModel();

                var result = _repository.GetById("SP_GETBYID_DISEASEOFTHEINSUREDMAPPING", id);
                foreach (DataRow item in result.Rows)
                {
                    diseaseOfTheInsuredMappingModel.ID = Convert.ToInt32(item["ID"]);
                    diseaseOfTheInsuredMappingModel.INSUREDREGISTRATIONID = (int)item["INSUREDREGISTRATIONID"];
                    diseaseOfTheInsuredMappingModel.DISEASEID = (int)item["DISEASEID"];
                    diseaseOfTheInsuredMappingModel.CREATEBY = (decimal)item["CREATEBY"];
                    diseaseOfTheInsuredMappingModel.CREATEDATE = item["CREATEDATE"].ToString();
                    diseaseOfTheInsuredMappingModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    diseaseOfTheInsuredMappingModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                _unitOfWork.Dispose();
                return diseaseOfTheInsuredMappingModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(DiseaseOfTheInsuredMappingModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<DiseaseOfTheInsuredMappingModel, DiseaseOfTheInsuredMapping>(model);
                var result = _repository.Update("SP_UPDATE_CUSTOMER", entity);
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