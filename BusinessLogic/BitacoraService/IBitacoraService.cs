using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BitacoraService
{
    public interface IBitacoraService
    {
        void InsertBitacora(BitacoraSeguimiento objBitacora);
        List<BitacoraSeguimiento> GetAllBitacoras();
        void DeleteBitacora(int bitacoraId);
    }
}
