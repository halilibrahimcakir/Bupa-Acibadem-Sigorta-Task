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
    public class EmployeeTypeService : IEmployeeTypeService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<EmployeeType> _repository;

        public EmployeeTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<EmployeeType>();
        }
        public bool Add(EmployeeTypeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<EmployeeTypeModel, EmployeeType>(model);
                var result = _repository.Add("SP_CREATE_EMPLOYEETYPE", entity);
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
                _repository.Delete("SP_DELETE_EMPLOYEETYPE", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmployeeTypeModel> GetAll()
        {
            try
            {
                List<EmployeeTypeModel> list = new List<EmployeeTypeModel>();

                var result = _repository.GetAll("SP_GETALL_EMPLOYEETYPE");
                foreach (DataRow item in result.Rows)
                {
                    EmployeeTypeModel employeeTypeModel = new EmployeeTypeModel();


                    employeeTypeModel.ID = Convert.ToInt32(item["ID"]);
                    employeeTypeModel.NAME = item["NAME"].ToString();
                    employeeTypeModel.CREATEBY = (int)item["CREATEBY"];
                    employeeTypeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    employeeTypeModel.UPDATEBY = (int)item["UPDATEBY"];
                    employeeTypeModel.UPDATEDATE = item["UPDATEDATE"].ToString();


                    list.Add(employeeTypeModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeTypeModel GetById(int id)
        {
            try
            {
                EmployeeTypeModel employeeTypeModel = new EmployeeTypeModel();

                var result = _repository.GetById("SP_GETBYID_EMPLOYEETYPE", id);
                foreach (DataRow item in result.Rows)
                {
                    employeeTypeModel.ID = Convert.ToInt32(item["ID"]);
                    employeeTypeModel.NAME = item["NAME"].ToString();
                    employeeTypeModel.CREATEBY = (int)item["CREATEBY"];
                    employeeTypeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    employeeTypeModel.UPDATEBY = (int)item["UPDATEBY"];
                    employeeTypeModel.UPDATEDATE = item["UPDATEDATE"].ToString();


                }
                _unitOfWork.Dispose();
                return employeeTypeModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(EmployeeTypeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<EmployeeTypeModel, EmployeeType>(model);
                var result = _repository.Update("SP_UPDATE_EMPLOYEETYPE", entity);
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