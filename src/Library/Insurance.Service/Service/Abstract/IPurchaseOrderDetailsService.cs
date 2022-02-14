using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IPurchaseOrderDetailsService
    {
        PurchaseOrderDetailsModel Add(PurchaseOrderDetailsModel model);
        bool Delete(int id);
        List<PurchaseOrderDetailsModel> GetAll();
        PurchaseOrderDetailsModel GetById(int id);
        bool Update(PurchaseOrderDetailsModel model);
    }
}
