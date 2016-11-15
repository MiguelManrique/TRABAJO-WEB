using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccess.RecursosRepository
{
    public class RecursosRepository : IRecursosRepository
    {
        public List<RecursoDigital> GetAllRecursos()
        {
            IncidenciasDBEntities IncidenciaModel = new IncidenciasDBEntities();
            List<RecursoDigital> recursos = (from c in IncidenciaModel.RecursoDigital
                                        //where c.Name.Contains("ing")
                                    select c).ToList();
            return recursos;
        }
    }
}
