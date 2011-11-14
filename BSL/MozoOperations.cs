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
        public IEnumerable<Mozo> GetAll()
        {
            try
            {
                MozoDao dao = new MozoDao();
                return dao.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mozos " + ex.Message);
                throw ex;
            }
        }

        public void Update(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.Update(m) != 1)
            {
                throw new Exception("No se actualizó el mozo");
            }
        }

        public void Insert(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.Insert(m) != 1)
            {
                throw new Exception("No se insertó el mozo");
            }
        }

        /// <summary>
        /// Cambia el estado del mozo a DESVINCULADO, no es una baja fisica
        /// </summary>
        /// <param name="m">mozo</param>
        public void Delete(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.Delete(m) != 1)
            {
                throw new Exception("No se desvinculó el mozo, error interno");
            }
        }

        public IEnumerable<Mozo> SearchByNombre(string filter)
        {
            try
            {
                MozoDao dao = new MozoDao();
                return dao.SearchByNombre(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mozos por nombre " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Mozo> SearchBySector(UInt32 sector)
        {
            try
            {
                MozoDao dao = new MozoDao();
                return dao.SearchBySector(sector);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mozos por sector " + ex.Message);
                throw ex;
            }
        }

        public Mozo GetOneByDni(UInt32 dni)
        {
            try
            {
                MozoDao dao = new MozoDao();
                return dao.GetOneByDni(dni);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener un mozo por DNI " + ex.Message);
                throw ex;
            }
        }
    }
}
