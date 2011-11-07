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
                Console.WriteLine("Error al obtener sectores: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Mesa> GetAll()
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mesas: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Mesa> GetFromSector(UInt32 sector)
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.GetFromSector(sector);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mesas: " + ex.Message);
                throw ex;
            }
        }

        public void Insert(Mesa p)
        {
            MesaDao dao = new MesaDao();
            if (dao.Insert(p) != 1)
            {
                throw new Exception("No se insertó la información");
            }
        }

        public void Delete(Mesa p)
        {
            MesaDao dao = new MesaDao();
            if (dao.Delete(p) != 1)
            {
                throw new Exception("No se eliminó la información");
            }
        }
    }
}
