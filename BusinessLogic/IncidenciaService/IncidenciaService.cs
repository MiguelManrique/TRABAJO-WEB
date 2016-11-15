using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


using DataAccess.IncidenciaRepository;

namespace BusinessLogic.IncidenciaService
{
    public class IncidenciaService : IIncidenciaService
    {
        

        public void InsertIncidencia(Incidencia objIncidencia)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            repository.InsertIncidencia(objIncidencia);
        }

        public void UpdateIncidencia(Incidencia objIncidencia)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            repository.UpdateIncidencia(objIncidencia);
        }
        public void DeleteIncidencia(int incidenciaId)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            repository.DeleteIncidencia(incidenciaId);
        }

        public Incidencia GetIncidenciaById(int incidenciaId)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            return repository.GetIncidenciaById(incidenciaId);
        }

        public List<Incidencia> GetAllIncidencia()
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            return repository.GetAllIncidencia();
        }

        public List<Incidencia> GetAllIncidenciaPorFecha(int id, DateTime fecha1, DateTime fecha2)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            return repository.GetAllIncidenciaPorFecha(id, fecha1, fecha2);
        }

        public List<Incidencia> GetAllIncidenciasPorCliente(int client)
        {
            IIncidenciaRepository repository = new IncidenciaRepository();
            return repository.GetAllIncidenciasPorCliente(client);
        }
        

    }
}