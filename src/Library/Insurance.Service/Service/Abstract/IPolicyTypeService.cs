using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPolicyTypeService
    {
        bool Add(PolicyTypeModel model);
        bool Delete(int id);
        List<PolicyTypeModel> GetAll();
        PolicyTypeModel GetById(int id);
        bool Update(PolicyTypeModel model);
    }
}
