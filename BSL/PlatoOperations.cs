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

        public IEnumerable<Plato> SearchByDesc(string filter)
        {
            try
            {
                PlatoDao dao = new PlatoDao();
                return dao.SearchByDesc(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener platos " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Plato> SearchByDescDisponible(string filter)
        {
            try
            {
                PlatoDao dao = new PlatoDao();
                return dao.SearchByDescDisponible(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener platos " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Plato> SearchByRubro(string rubro)
        {
            try
            {
                PlatoDao dao = new PlatoDao();
                return dao.SearchByRubro(rubro);
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
                throw new Exception("No se actualizó el plato");
            }
        }

        public void Insert(Plato p)
        {
            PlatoDao dao = new PlatoDao();
            if (dao.Insert(p) != 1)
            {
                throw new Exception("No se insertó el plato");
            }
        }

        public void Delete(Plato p)
        {
            PlatoDao dao = new PlatoDao();
           dao.Inactivate(p);
        }

        public void Activate(Plato p)
        {
            PlatoDao dao = new PlatoDao();
            if (dao.Activate(p) != 1)
            {
                throw new Exception("No se actualizó como DISPONIBLE el plato");
            }
        }
    }
}
