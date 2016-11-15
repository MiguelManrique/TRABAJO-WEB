using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BitacoraRepository
{
    public class BitacoraRepository : IBitacoraRepository
    {
        public void DeleteBitacora(int bitacoraId)
        {
            using (var model = new IncidenciasDBEntities())
            {
                Incidencia objIncidencia = model.Incidencia.Find(bitacoraId);
                if (objIncidencia != null)
                {
                    model.Incidencia.Remove(objIncidencia);
                    model.SaveChanges();
                }
            }
        }

        public List<Entities.BitacoraSeguimiento> GetAllBitacoras()
        {
            IncidenciasDBEntities IncidenciasBDModel = new IncidenciasDBEntities();
            List<BitacoraSeguimiento> bitacora = (from c in IncidenciasBDModel.BitacoraSeguimiento.Include("Incidencia")
                                                      //where c.Name.Contains("ing")
                                                  select c).ToList();
            return bitacora;
        }

        public void InsertBitacora(BitacoraSeguimiento objBitacora)
        {
            using (var model = new IncidenciasDBEntities())
            {
                model.BitacoraSeguimiento.Add(objBitacora);
                model.SaveChanges();
            }
        }
    }
}
