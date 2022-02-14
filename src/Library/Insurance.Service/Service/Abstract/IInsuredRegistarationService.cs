using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IInsuredRegistarationService
    {
        InsuredRegistrationModel Add(InsuredRegistrationModel model);
        bool Delete(int id);
        List<InsuredRegistrationModel> GetAll();
        InsuredRegistrationModel GetById(int id);
        bool Update(InsuredRegistrationModel model);
    }
}
