using Insurance.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Service
{
    public interface IProximityDegreeService
    {
        bool Add(ProximityDegreeModel model);
        bool Delete(int id);
        List<ProximityDegreeModel> GetAll();
        ProximityDegreeModel GetById(int id);
        bool Update(ProximityDegreeModel model);
    }
}
