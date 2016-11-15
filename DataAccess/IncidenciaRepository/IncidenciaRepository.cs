using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;



namespace DataAccess.IncidenciaRepository
{
    public class IncidenciaRepository : IIncidenciaRepository
    {
        //public void InsertCourse(Entities.Cours objCourse)
        //{
        //    using (var model = new UPCModelEntities())
        //    {
        //        model.Courses.Add(objCourse);
        //        model.SaveChanges();
        //    }
        //}

        //public void UpdateCourse(Cours objCourse)
        //{
        //    using (var model = new UPCModelEntities())
        //    {
        //        var original = model.Courses.Find(objCourse.Id);

        //        if (original != null)
        //        {
        //            model.Entry(original).CurrentValues.SetValues(objCourse);
        //            model.SaveChanges();
        //        }
        //    }
        //}

        //public void DeleteCourse(int courseId)
        //{
        //    using (var model = new UPCModelEntities())
        //    {
        //        Cours objCourse = model.Courses.Find(courseId);
        //        if (objCourse != null)
        //        {
        //            model.Courses.Remove(objCourse);
        //            model.SaveChanges();
        //        }
        //    }
        //}

        //public Cours GetCourseById(int courseId)
        //{
        //    using (var model = new UPCModelEntities())
        //    {
        //        var course = from c in model.Courses
        //                     where c.Id == courseId
        //                     select c;
        //        return course.FirstOrDefault();
        //    }
        //}

        //public List<Cours> GetAllCourses()
        //{
        //    using (var model = new UPCModelEntities())
        //    {

        //        var courses = from c in model.Courses.Include("Career")
        //                      select c;
        //        return courses.ToList();
        //    }
        //}

        public void InsertIncidencia(Incidencia objIncidencia)
        {
            using (var model = new IncidenciasDBEntities())
           {
               model.Incidencia.Add(objIncidencia);
               model.SaveChanges();
           }
        }

        public void UpdateIncidencia(Incidencia objIncidencia)
        {
            using (var model = new IncidenciasDBEntities())
            {
               var original = model.Incidencia.Find(objIncidencia.Id);

                      if (original != null)
                        {
                            model.Entry(original).CurrentValues.SetValues(objIncidencia);
                            model.SaveChanges();
                        }
            }
        }
        public void DeleteIncidencia(int incidenciaId)
        {
            using (var model = new IncidenciasDBEntities())
            {
                Incidencia objIncidencia = model.Incidencia.Find(incidenciaId);
                if (objIncidencia != null)
                {
                    model.Incidencia.Remove(objIncidencia);
                    model.SaveChanges();
                }
            }
        }

        public Incidencia GetIncidenciaById(int incidenciaId)
        {
            using (var model = new IncidenciasDBEntities())
            {
                var incidencia = from c in model.Incidencia
                             where c.Id == incidenciaId
                             select c;
                return incidencia.FirstOrDefault();
            }
        }

       

        public List<Incidencia> GetAllIncidencia()
        {
            using (var model = new IncidenciasDBEntities())
            {

                 var incidencia = from c in model.Incidencia.Include("Estado").Include("RecursoDigital").Include("Cliente").Include("Usuario")
                               select c;
                 return incidencia.ToList();
            }
        }

        public List<Incidencia> GetAllIncidenciasPorCliente(int client)
        {

            using (var model = new IncidenciasDBEntities())
            {

                var incidencia = from c in model.Incidencia
                                 where c.ICliente == client
                                 select c;
                return incidencia.ToList();
            }
 
        }

        public List<Incidencia> GetAllIncidenciaPorFecha(int id, DateTime fecha1, DateTime fecha2)
        {
            using (var model = new IncidenciasDBEntities())
            {

                var Incidencia = from c in model.Incidencia
                                 where c.ICliente == id
                                 where (c.Fecha >= fecha1 && c.Fecha <= fecha2)
                                
                                
                                 select c;
                return Incidencia.ToList();

               
            
                
            }
        }


    }
}
