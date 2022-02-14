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
    public class CustomerService : ICustomerService
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Customer> _repository;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<Customer>();
        }
        public CustomerModel Add(CustomerModel model)
        {
            try
            {
                List<CustomerModel> customerList = new List<CustomerModel>();
                customerList.AddRange(GetAll());
                var Id = customerList.Select(x => x.ID).Max() + 1;

                var entity = LazyObject.Mapper.Map<CustomerModel, Customer>(model);
                var result = _repository.Add("SP_CREATE_CUSTOMER", entity);
                model.ID = Id;
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
                _repository.Delete("SP_DELETE_CUSTOMER", id);
                _unitOfWork.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public List<CustomerModel> GetAll()
        {
            try
            {
                List<CustomerModel> list = new List<CustomerModel>();

                    var result = _repository.GetAll("SP_GETALL_CUSTOMER");
                    foreach (DataRow item in result.Rows)
                    {
                        CustomerModel customerModel = new CustomerModel();

                        customerModel.ID = Convert.ToInt32(item["ID"]);
                        customerModel.USERNAME = item["USERNAME"].ToString();
                        customerModel.PASSWORD = item["PASSWORD"].ToString();
                        customerModel.NATIONALITY = item["NATIONALITY"].ToString();
                        customerModel.IDENTIFICATIONNUMBER = item["IDENTIFICATIONNUMBER"].ToString();
                        customerModel.BIRTHDATE = item["BIRTHDATE"].ToString();
                        customerModel.GENDER = item["GENDER"].ToString();
                        customerModel.EMAIL = item["EMAIL"].ToString();
                        customerModel.PHONE = item["PHONE"].ToString();
                        customerModel.ADRESS = item["ADRESS"].ToString();
                        customerModel.CREATEDATE = item["CREATEDATE"].ToString();
                        customerModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                        customerModel.CREATEBY = (decimal)item["CREATEBY"];
                        customerModel.UPDATEBY = (decimal)item["UPDATEBY"];

                        list.Add(customerModel);
                    }
                _unitOfWork.Dispose();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public CustomerModel GetById(int id)
        {
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    CustomerModel customerModel = new CustomerModel();

                    var result = uow.CustomerRepository.GetById("SP_GETBYID_CUSTOMER", id);
                    foreach (DataRow item in result.Rows)
                    {
                        customerModel.ID = Convert.ToInt32(item["ID"]);
                        customerModel.USERNAME = item["USERNAME"].ToString();
                        customerModel.PASSWORD = item["PASSWORD"].ToString();
                        customerModel.NATIONALITY = item["NATIONALITY"].ToString();
                        customerModel.IDENTIFICATIONNUMBER = item["IDENTIFICATIONNUMBER"].ToString();
                        customerModel.BIRTHDATE = item["BIRTHDATE"].ToString();
                        customerModel.GENDER = item["GENDER"].ToString();
                        customerModel.EMAIL = item["EMAIL"].ToString();
                        customerModel.PHONE = item["PHONE"].ToString();
                        customerModel.ADRESS = item["ADRESS"].ToString();
                        customerModel.CREATEDATE = item["CREATEDATE"].ToString();
                        customerModel.UPDATEDATE = item["UPDATEDATE"].ToString();
                        customerModel.CREATEBY = (decimal)item["CREATEBY"];
                        customerModel.UPDATEBY = (decimal)item["UPDATEBY"];
                    }
                    _unitOfWork.Dispose();
                    return customerModel;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(CustomerModel model)
        {
            try
            {
                var entity = LazyObject.Mapper.Map<CustomerModel, Customer>(model);
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