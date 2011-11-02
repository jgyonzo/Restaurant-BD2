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
                throw new Exception("No se actualizo la informacion");
            }
        }

        public void Insert(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.Insert(m) != 1)
            {
                throw new Exception("No se inserto la informacion");
            }
        }

        public void Delete(Mozo m)
        {
            MozoDao dao = new MozoDao();
            if (dao.Delete(m) != 1)
            {
                throw new Exception("No se elimino el mozo");
            }
        }
    }
}
