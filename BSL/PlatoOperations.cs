using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL;

namespace BSL
{
    public class PlatoOperations
    {
        public IEnumerable<Plato> GetAll()
        {
            try
            {
                PlatoDao dao = new PlatoDao();
                return dao.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener platos " + ex.Message);
                throw ex;
            }
        }

        public Plato GetOne(UInt32 id)
        {
            try
            {
                PlatoDao dao = new PlatoDao();
                return dao.GetOne(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener un plato " + ex.Message);
                throw ex;
            }
        }

        public void Update(Plato p)
        {
            PlatoDao dao = new PlatoDao();
            if (dao.Update(p) != 1)
            {
                throw new Exception("No se actualizo la informacion");
            }
        }

        public void Insert(Plato p)
        {
            PlatoDao dao = new PlatoDao();
            if (dao.Insert(p) != 1)
            {
                throw new Exception("No se inserto la informacion");
            }
        }

        public void Delete(Plato p)
        {
            PlatoDao dao = new PlatoDao();
            if (dao.Delete(p) != 1)
            {
                throw new Exception("No se elimino el plato");
            }
        }
    }
}
