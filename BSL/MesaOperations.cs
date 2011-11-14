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
        public IEnumerable<Sector> GetAllSectores()
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.GetAllSectores();
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

        /// <summary>
        /// Dado un sector, devuelve las mesas EN SERVICIO y que no se encuentran en una venta ABIERTA
        /// </summary>
        public IEnumerable<Mesa> GetDisponiblesMesasBySector(UInt32 sector)
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.GetDisponiblesMesasBySector(sector);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mesas: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Mesa> SearchByEstado(string estado)
        {
            try
            {
                MesaDao dao = new MesaDao();
                return dao.SearchByEstado(estado);
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
                throw new Exception("No se agregó la mesa");
            }
        }

        public void Inactivate(Mesa p)
        {
            MesaDao dao = new MesaDao();
            if (dao.Inactivate(p) != 1)
            {
                throw new Exception("No se actualizó como FUERA DE SERVICIO la mesa seleccionada");
            }
        }

        public void Activate(Mesa p)
        {
            MesaDao dao = new MesaDao();
            dao.Activate(p);
        }
    }
}
