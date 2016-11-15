using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace BusinessLogic.IncidenciaService
{
    public interface IIncidenciaService
    {
       
        //ejemplo
        //void InsertEntidad1(Cours objCourse);
        //void UpdateEntidad1(Cours objCourse);
        //void DeleteEntidad1(int courseId);
        //Cours GetCourseById(int courseId);
        //List<Cours> GetAllCourses();


        void InsertIncidencia(Incidencia objIncidencia);
        void UpdateIncidencia(Incidencia objIncidencia);
        void DeleteIncidencia(int incidenciaId);
        Incidencia GetIncidenciaById(int incidenciaId);
        List<Incidencia> GetAllIncidencia();
        List<Incidencia> GetAllIncidenciasPorCliente(int client);

        List<Incidencia> GetAllIncidenciaPorFecha(int id, DateTime fecha1, DateTime fecha2);

    }
}
