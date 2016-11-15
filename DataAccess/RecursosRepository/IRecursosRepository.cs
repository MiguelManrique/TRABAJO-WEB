using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
namespace DataAccess.RecursosRepository
{
    public interface IRecursosRepository
    {
        List<RecursoDigital> GetAllRecursos();
    }
}
