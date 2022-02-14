using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPaymentTypeService
    {
        bool Add(PaymentTypeModel model);
        bool Delete(int id);
        List<PaymentTypeModel> GetAll();
        PaymentTypeModel GetById(int id);
        bool Update(PaymentTypeModel model);
    }
}
