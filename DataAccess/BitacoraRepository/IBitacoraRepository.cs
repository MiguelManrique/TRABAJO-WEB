using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BitacoraRepository
{
    public interface IBitacoraRepository
    {
        void InsertBitacora(BitacoraSeguimiento objBitacora);
        List<BitacoraSeguimiento> GetAllBitacoras();

        void DeleteBitacora(int bitacoraId);
    }
}
