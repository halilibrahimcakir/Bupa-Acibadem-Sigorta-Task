using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IEmployeeService
    {
        bool Add(EmployeeModel model);
        bool Delete(int id);
        List<EmployeeModel> GetAll();
        EmployeeModel GetById(int id);
        bool Update(EmployeeModel model);
    }
}
