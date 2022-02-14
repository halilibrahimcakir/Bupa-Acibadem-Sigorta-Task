using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IDiseaseService
    {
        bool Add(DiseaseModel model);
        bool Delete(int id);
        List<DiseaseModel> GetAll();
        DiseaseModel GetById(int id);
        bool Update(DiseaseModel model);
    }
}
