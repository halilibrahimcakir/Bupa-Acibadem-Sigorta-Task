using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IEmployeeTypeService
    {
        bool Add(EmployeeTypeModel model);
        bool Delete(int id);
        List<EmployeeTypeModel> GetAll();
        EmployeeTypeModel GetById(int id);
        bool Update(EmployeeTypeModel model);
    }
}
