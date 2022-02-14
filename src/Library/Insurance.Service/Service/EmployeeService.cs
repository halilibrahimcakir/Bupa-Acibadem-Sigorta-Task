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
    public class EmployeeService : IEmployeeService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<Employee>();
        }
        public bool Add(EmployeeModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<EmployeeModel, Employee>(model);
                var result = _repository.Add("SP_CREATE_Employee", entity);
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
                _repository.Delete("SP_DELETE_EMPLOYEE", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmployeeModel> GetAll()
        {
            try
            {
                List<EmployeeModel> list = new List<EmployeeModel>();

                var result = _repository.GetAll("SP_GETALL_EMPLOYEE");
                foreach (DataRow item in result.Rows)
                {
                    EmployeeModel employeeModel = new EmployeeModel();

                    employeeModel.ID = Convert.ToInt32(item["ID"]);
                    employeeModel.EMPLOYEETYPEID = (decimal)item["EMPLOYEETYPEID"];
                    employeeModel.EMPLOYEEMANAGERID = (decimal)item["EMPLOYEEMANAGERID"];
                    employeeModel.NAME = item["NAME"].ToString();
                    employeeModel.SURNAME = item["SURNAME"].ToString();
                    employeeModel.USERNAME = item["USERNAME"].ToString();
                    employeeModel.PASSWORD = item["PASSWORD"].ToString();
                    employeeModel.PHONE = item["PHONE"].ToString();
                    employeeModel.ADRESS = item["ADRESS"].ToString();
                    employeeModel.EMAIL = item["EMAIL"].ToString();
                    employeeModel.TITLE = item["TITLE"].ToString();
                    employeeModel.CREATEBY = (decimal)item["CREATEBY"];
                    employeeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    employeeModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    employeeModel.UPDATEDATE = item["UPDATEDATE"].ToString();

                    list.Add(employeeModel);
                }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeModel GetById(int id)
        {
            try
            {

                EmployeeModel employeeModel = new EmployeeModel();

                var result = _repository.GetById("SP_GETBYID_EMPLOYEE", id);
                foreach (DataRow item in result.Rows)
                {
                    employeeModel.ID = Convert.ToInt32(item["ID"]);
                    employeeModel.EMPLOYEETYPEID = (int)item["EMPLOYEETYPEID"];
                    employeeModel.EMPLOYEEMANAGERID = (int)item["EMPLOYEEMANAGERID"];
                    employeeModel.NAME = item["NAME"].ToString();
                    employeeModel.SURNAME = item["SURNAME"].ToString();
                    employeeModel.USERNAME = item["USERNAME"].ToString();
                    employeeModel.PASSWORD = item["PASSWORD"].ToString();
                    employeeModel.PHONE = item["PHONE"].ToString();
                    employeeModel.ADRESS = item["ADRESS"].ToString();
                    employeeModel.EMAIL = item["EMAIL"].ToString();
                    employeeModel.TITLE = item["TITLE"].ToString();
                    employeeModel.CREATEBY = (decimal)item["CREATEBY"];
                    employeeModel.CREATEDATE = item["CREATEDATE"].ToString();
                    employeeModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    employeeModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                }
                _unitOfWork.Dispose();
                return employeeModel;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(EmployeeModel model)
        {
                var entity = LazyObject.Mapper.Map<EmployeeModel, Employee>(model);
                var result = _repository.Update("SP_UPDATE_EMPLOYEE", entity);
                _unitOfWork.Dispose();
                return result;            
        }
    }
}