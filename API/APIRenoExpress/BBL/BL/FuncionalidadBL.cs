using DAL.RenoExpress;
using LOG.RenoExpress;
using MOD.RenoExpress;
using MOD.RenoExpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RenoExpress
{
    public class FuncionalidadBL
    {
        public async Task<List<Funcionalidad>> ListFuncionalidades()
        {
            FuncionalidadDal db = new FuncionalidadDal();
            var funcionalities = new List<Funcionalidad>();
            try
            {
                funcionalities = await db.recuperarFuncionalidad();
            }
            catch (Exception ex)
            {
                funcionalities.Add(new Funcionalidad
                {
                    Message = "No se pudieron recuperar datos de funcionalidades."
                });
                Log.RegistrarLogAsync("<<FuncionalidadBL.ListFuncionalidades>> Error al recuperar datos FuncionalidadDal.recuperarFuncionalidad", ex.ToString());
            }
    
            return funcionalities;
        }

        public async Task<Funcionalidad> guardarFuncionalidad(Funcionalidad varFuncionalidad)
        {
            FuncionalidadDal db = new FuncionalidadDal();
            var guardarFuncionalidad = new Funcionalidad();
            try
            {
                guardarFuncionalidad = await db.CrearFuncionalidad(varFuncionalidad);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<FuncionalidadBL.guardarFuncionalidad>> Error al guardar datos FuncionalidadDal.CrearFuncionalidad", ex.ToString());
            }

            return guardarFuncionalidad;
        }

        public async Task<Funcionalidad> cambiarEstadoFuncionalidad(Funcionalidad varFuncionalidad)
        {
            FuncionalidadDal db = new FuncionalidadDal();
            var estadoFuncionalidad = new Funcionalidad();
            try
            {
                estadoFuncionalidad = await db.cambiarEstadoFuncionalidad(varFuncionalidad);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<FuncionalidadBL.cambiarEstadoFuncionalidad>> Error al guardar datos FuncionalidadDal.cambiarEstadoFuncionalidad", ex.ToString());
            }

            return estadoFuncionalidad;
        }

        public async Task<Funcionalidad> guardarCambiosFuncionalidad(Funcionalidad varFuncionalidad)
        {
            FuncionalidadDal db = new FuncionalidadDal();
            var guardarFuncionalidad = new Funcionalidad();
            try
            {
                guardarFuncionalidad = await db.EditarFuncionalidad(varFuncionalidad);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<FuncionalidadBL.guardarCambiosFuncionalidad>> Error al guardar cambios FuncionalidadDal.EditarFuncionalidad", ex.ToString());
            }

            return guardarFuncionalidad;
        }

        public async Task<List<Funcionalidad>> recuperarFuncionalidad()
        {
            FuncionalidadDal db = new FuncionalidadDal();
            var listarFuncionalidad = new List<Funcionalidad>();
            try
            {
                listarFuncionalidad = await db.ListadoFuncionalidad();
            }
            catch (Exception ex)
            {
                listarFuncionalidad.Add(new Funcionalidad
                {
                    Message = "No se pudieron recuperar datos de funcionalidades."
                });
                Log.RegistrarLogAsync("<<FuncionalidadBL.recuperarFuncionalidad>> Error al recuperar datos FuncionalidadDal.ListadoFuncionalidad", ex.ToString());
            }

            return listarFuncionalidad;
        }
    }
}
