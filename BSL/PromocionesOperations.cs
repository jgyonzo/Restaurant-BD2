using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entities;
using DAL;
using System.Collections;

namespace BSL
{
    public class PromocionesOperations
    {
        public IEnumerable<Promocion> GetAll()
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones " + ex.Message);
                throw ex;
            }
        }

        public Promocion GetOne(UInt32 id)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetOne(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Plato_Promocion> GetAllPlatos(Promocion p)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetPlatos(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los platos de la promocion " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Promocion> GetAllFiltering(string filter)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetAllFiltering(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones: " + ex.Message);
                throw ex;
            }
        }

        public void Update(Promocion p, IEnumerable platos)
        {
            PromocionesDao dao = new PromocionesDao();
            if (dao.Update(p,platos) != 1)
            {
                throw new Exception("No se actualizo la informacion");
            }
        }

        public void Insert(Promocion p, IEnumerable platos)
        {
            PromocionesDao dao = new PromocionesDao();
            if (dao.Insert(p,platos) != 1)
            {
                throw new Exception("No se inserto la informacion");
            }
        }

        public void Delete(Promocion p)
        {
            PromocionesDao dao = new PromocionesDao();
            if (dao.Delete(p) != 1)
            {
                throw new Exception("No se elimino la promocion");
            }
        }
    }
}
