using Insurance.Data.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Repository
{
    public class DiseaseRepository : RepositoryBase<Disease>, IDiseaseRepository
    {

    }

    public interface IDiseaseRepository
    {
       
    }
}