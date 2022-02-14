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
    public class ProximityDegreeService : IProximityDegreeService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<ProximityDegree> _repository;

        public ProximityDegreeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<ProximityDegree>();
        }
        public bool Add(ProximityDegreeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<ProximityDegreeModel, ProximityDegree>(model);
                var result = _repository.Add("SP_CREATE_PROXIMITYDEGREE", entity);
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
                _repository.Delete("SP_DELETE_PROXIMITYDEGREE", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProximityDegreeModel> GetAll()
        {
            try
            {
                List<ProximityDegreeModel> list = new List<ProximityDegreeModel>();

                var result = _repository.GetAll("SP_GETALL_PROXIMITYDEGREE");
                foreach (DataRow item in result.Rows)
                {
                    ProximityDegreeModel proximityDegreeModel = new ProximityDegreeModel();

                    proximityDegreeModel.ID = Convert.ToInt32(item["ID"]);
                    proximityDegreeModel.PROXIMITYNAME = item["USERNAME"].ToString();
                    proximityDegreeModel.CREATEBY = (int)item["PASSWORD"];
                    proximityDegreeModel.CREATEDATE = item["NATIONALITY"].ToString();
                    proximityDegreeModel.UPDATEBY = (int)item["IDENTIFICATIONNUMBER"];
                    proximityDegreeModel.UPDATEDATE = item["BIRTHDATE"].ToString();

                    list.Add(proximityDegreeModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProximityDegreeModel GetById(int id)
        {
            try
            {
                ProximityDegreeModel proximityDegreeModel = new ProximityDegreeModel();

                var result = _repository.GetById("SP_GETBYID_PROXIMITYDEGREE", id);
                foreach (DataRow item in result.Rows)
                {
                    proximityDegreeModel.ID = Convert.ToInt32(item["ID"]);
                    proximityDegreeModel.PROXIMITYNAME = item["USERNAME"].ToString();
                    proximityDegreeModel.CREATEBY = (int)item["PASSWORD"];
                    proximityDegreeModel.CREATEDATE = item["NATIONALITY"].ToString();
                    proximityDegreeModel.UPDATEBY = (int)item["IDENTIFICATIONNUMBER"];
                    proximityDegreeModel.UPDATEDATE = item["BIRTHDATE"].ToString();

                }
                return proximityDegreeModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(ProximityDegreeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<ProximityDegreeModel, ProximityDegree>(model);
                var result = _repository.Update("SP_UPDATE_PROXIMITYDEGREE", entity);
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