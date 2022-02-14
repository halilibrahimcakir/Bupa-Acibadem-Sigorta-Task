using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPolicyTypeDetailsService
    {
        //bool Add(PolicyTypeDetailsModel model);
        //bool Delete(int id);
        //List<PolicyTypeDetailsModel> GetAll();
        PolicyTypeDetailsModel GetById(int id);
        //bool Update(PolicyTypeDetailsModel model);
    }
}
