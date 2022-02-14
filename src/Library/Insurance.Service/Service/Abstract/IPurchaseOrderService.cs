using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPurchaseOrderService
    {
        PurchaseOrderModel Add(PurchaseOrderModel model);
        bool Delete(int id);
        List<PurchaseOrderModel> GetAll();
        PurchaseOrderModel GetById(int id);
        bool Update(PurchaseOrderModel model);
    }
}
