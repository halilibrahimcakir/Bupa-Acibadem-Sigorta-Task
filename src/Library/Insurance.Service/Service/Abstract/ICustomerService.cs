using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface ICustomerService
    {
        CustomerModel Add(CustomerModel model);
        bool Delete(int id);
        List<CustomerModel> GetAll();
        CustomerModel GetById(int id);
        bool Update(CustomerModel model);
    }
}
