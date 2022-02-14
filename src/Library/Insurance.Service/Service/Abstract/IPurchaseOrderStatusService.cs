using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPurchaseOrderStatusService
    {
        bool Add(PurchaseOrderStatusModel model);
        bool Delete(int id);
        List<PurchaseOrderStatusModel> GetAll();
        PurchaseOrderStatusModel GetById(int id);
        bool Update(PurchaseOrderStatusModel model);
    }
}
