using DataAccess.BitacoraRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BitacoraService
{
    public class BitacoraService : IBitacoraService
    {
        public void DeleteBitacora(int bitacoraId)
        {
      
            IBitacoraRepository repository = new BitacoraRepository();
            repository.DeleteBitacora(bitacoraId);
        

    }

    public List<Entities.BitacoraSeguimiento> GetAllBitacoras()
        {
            IBitacoraRepository repository = new BitacoraRepository();
            return repository.GetAllBitacoras();
        }

        public void InsertBitacora(Entities.BitacoraSeguimiento objBitacora)
        {
            IBitacoraRepository repository = new BitacoraRepository();
            repository.InsertBitacora(objBitacora);
        }
    }
}
