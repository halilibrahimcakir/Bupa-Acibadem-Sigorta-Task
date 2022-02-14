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
    public class DiseaseService : IDiseaseService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Disease> _repository;

        public DiseaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<Disease>();
        }
        public bool Add(DiseaseModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<DiseaseModel, Disease>(model);
                var result = _repository.Add("SP_CREATE_DISEASE", entity);
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
                _repository.Delete("SP_DELETE_DISEASE", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public List<DiseaseModel> GetAll()
        {
            try
            {
                List<DiseaseModel> list = new List<DiseaseModel>();

                var result = _repository.GetAll("SP_GETALL_DISEASE");
                foreach (DataRow item in result.Rows)
                {
                    DiseaseModel diseaseModel = new DiseaseModel();

                    diseaseModel.ID = Convert.ToInt32(item["ID"]);
                    diseaseModel.NAME = item["NAME"].ToString();
                    diseaseModel.RAISE = (decimal)item["RAISE"];
                    diseaseModel.CREATEBY = (int)item["CREATEDATE"];
                    diseaseModel.CREATEDATE = item["CREATEDATE"].ToString();
                    diseaseModel.UPDATEBY = (int)item["UPDATEBY"];
                    diseaseModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(diseaseModel);
                }
                return list;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DiseaseModel GetById(int id)
        {
            try
            {

                DiseaseModel diseaseModel = new DiseaseModel();

                var result = _repository.GetById("SP_GETBYID_DISEASE", id);
                foreach (DataRow item in result.Rows)
                {
                    diseaseModel.ID = Convert.ToInt32(item["ID"]);
                    diseaseModel.NAME = item["NAME"].ToString();
                    diseaseModel.RAISE = (decimal)item["RAISE"];
                    diseaseModel.CREATEBY = (int)item["CREATEDATE"];
                    diseaseModel.CREATEDATE = item["CREATEDATE"].ToString();
                    diseaseModel.UPDATEBY = (int)item["UPDATEBY"];
                    diseaseModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                }
                return diseaseModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Update(DiseaseModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<DiseaseModel, Disease>(model);
                var result = _repository.Update("SP_UPDATE_DISEASE", entity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}