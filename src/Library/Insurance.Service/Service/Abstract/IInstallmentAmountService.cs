using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IInstallmentAmountService
    {
        bool Add(InstallmentAmountModel model);
        bool Delete(int id);
        List<InstallmentAmountModel> GetAll();
        InstallmentAmountModel GetById(int id);
        bool Update(InstallmentAmountModel model);
    }
}
