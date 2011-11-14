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

        public IEnumerable<Plato_Promocion> GetPlatosByPromo(Promocion p)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetPlatosByPromo(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los platos de la promocion " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Plato_Promocion> GetPromosByPlato(Plato p)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.GetPromosByPlato(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las promociones asociadas al plato " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Promocion> SearchByDesc(string filter)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.SearchByDesc(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones: " + ex.Message);
                throw ex;
            }
        }

        public IEnumerable<Promocion> SearchByEstado(string estado)
        {
            try
            {
                PromocionesDao dao = new PromocionesDao();
                return dao.SearchByEstado(estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener promociones: " + ex.Message);
                throw ex;
            }
        }

        public void Update(Promocion p, IEnumerable<Plato> platos)
        {
            PromocionesDao dao = new PromocionesDao();
            dao.Update(p,platos);
        }

        public void Insert(Promocion p, IEnumerable<Plato> platos)
        {
            PromocionesDao dao = new PromocionesDao();
            dao.Insert(p,platos);
        }

        public void Inactivate(Promocion p)
        {
            PromocionesDao dao = new PromocionesDao();
            if (dao.Inactivate(p) != 1)
            {
                throw new Exception("No se actualizó como NO DISPONIBLE la promoción");
            }
        }

        public void Activate(Promocion p)
        {
            PromocionesDao dao = new PromocionesDao();
            dao.Activate(p);
        }
    }
}
