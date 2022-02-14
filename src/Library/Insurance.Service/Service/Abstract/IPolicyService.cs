using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPolicyService
    {
        bool Add(PolicyModel model);
        bool Delete(int id);
        List<PolicyModel> GetAll();
        PolicyModel GetById(int id);
        bool Update(PolicyModel model);
    }
}
