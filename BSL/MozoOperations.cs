using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL;

namespace BSL
{
    public class MozoOperations
    {
        public IEnumerable<Mozo> getAll()
        {
            try
            {
                MozoDao dao = new MozoDao();
                return dao.getAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mozos " + ex.Message);
                throw ex;
            }
        }

        public void update(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.update(m) != 1)
            {
                throw new Exception("No se actualizo la informacion");
            }
        }
    }
}
