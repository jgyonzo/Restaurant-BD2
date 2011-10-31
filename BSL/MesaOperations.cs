using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL;

namespace BSL
{
    public class MesaOperations
    {
        public IEnumerable<Sector> getAllSectores()
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.getAllSectores();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mozos " + ex.Message);
                throw ex;
            }
        }
    }
}
