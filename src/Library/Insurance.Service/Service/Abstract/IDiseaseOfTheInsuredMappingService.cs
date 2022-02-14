using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IDiseaseOfTheInsuredMappingService
    {
        bool Add(DiseaseOfTheInsuredMappingModel model);
        bool Delete(int id);
        List<DiseaseOfTheInsuredMappingModel> GetAll();
        DiseaseOfTheInsuredMappingModel GetById(int id);
        bool Update(DiseaseOfTheInsuredMappingModel model);
    }
}
