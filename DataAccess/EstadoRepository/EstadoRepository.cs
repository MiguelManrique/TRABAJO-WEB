using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.EstadoRepository
{
    public class EstadoRepository : IEstadoRepository
    {
        public List<Estado> GetAllEstados()
        {
            IncidenciasDBEntities IncidenciasBDModel = new IncidenciasDBEntities();
            List<Estado> estado = (from c in IncidenciasBDModel.Estado
                                        //where c.Name.Contains("ing")
                                    select c).ToList();
            return estado;
        }
    }
}
