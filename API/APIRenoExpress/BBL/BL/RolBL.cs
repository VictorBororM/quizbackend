using DAL.RenoExpress;
using LOG.RenoExpress;
using MOD.RenoExpress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.RenoExpress
{
    public class RolBL
    {
        public async Task<List<Rol>> ListRol()
        {
            RolDal db = new RolDal();
            var listarRol = new List<Rol>();
            try
            {
                listarRol = await db.recuperarRol();
            }
            catch (Exception ex)
            {
                listarRol.Add(new Rol
                {
                    Message = "No se pudieron recuperar datos de roles."
                });
                Log.RegistrarLogAsync("<<RolBL.ListRol>> Error al recuperar datos RolDal.recuperarRol", ex.ToString());
            }
    
            return listarRol;
        }

        public async Task<Rol> guardarRol(Rol varRol)
        {
            RolDal db = new RolDal();
            var guardarFuncionalidad = new Rol();
            try
            {
                guardarFuncionalidad = await db.CrearRol(varRol);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<RolBL.guardarRol>> Error al guardar datos RolDal.CrearRol", ex.ToString());
            }

            return guardarFuncionalidad;
        }

        public async Task<Rol> guardarCambiosRol(Rol varRol)
        {
            RolDal db = new RolDal();
            var guardarFuncionalidad = new Rol();
            try
            {
                guardarFuncionalidad = await db.EditarRol(varRol);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<RolBL.guardarCambiosRol>> Error al guardar datos RolDal.EditarRol", ex.ToString());
            }

            return guardarFuncionalidad;
        }

        public async Task<Rol> cambiarEstadoRol(Rol varRol)
        {
            RolDal db = new RolDal();
            var estadoFuncionalidad = new Rol();
            try
            {
                estadoFuncionalidad = await db.cambiarEstadoRol(varRol);
            }
            catch (Exception ex)
            {
                Log.RegistrarLogAsync("<<RolBL.cambiarEstadoRol>> Error al guardar datos RolDal.cambiarEstadoRol", ex.ToString());
            }

            return estadoFuncionalidad;
        }

        public async Task<List<treeView>> rolFuncionalidad(int idRol)
        {

            List<permisosFuncionalidad> valoresFuncion = new List<permisosFuncionalidad>();
            List<treeView> resultChildren = new List<treeView>();
            List<treeView> resultChildren2 = new List<treeView>();
            List<treeView> result = new List<treeView>();
            RolDal db = new RolDal();

            try
            {
                valoresFuncion = await db.recuperarFuncionalidad(idRol);
            }
            catch (Exception ex)
            {
                valoresFuncion.Add(new permisosFuncionalidad
                {
                    Message = "No se pudieron recuperar datos de funcionalidades."
                });
                Log.RegistrarLogAsync("<<RolBL.ListFuncionalidades>> Error al recuperar datos RolDal.recuperarFuncionalidad", ex.ToString());
            }

            foreach (var item in valoresFuncion)
            {
                resultChildren = new List<treeView>();
                resultChildren2 = new List<treeView>();
                if (item.Hijos > 0)
                {
                    foreach (var itemHijos in valoresFuncion)
                    {
                        if (item.Id == itemHijos.IdFuncionalidad)
                        {
                            if(itemHijos.Hijos > 0)
                            {
                                foreach (var itemHijos2 in valoresFuncion)
                                {
                                    if (itemHijos.Id == itemHijos2.IdFuncionalidad)
                                    {
                                        resultChildren2.Add(new treeView()
                                        {
                                            id = itemHijos2.Id,
                                            population = 1,
                                            text = itemHijos2.Descripcion,
                                            flagUrl = itemHijos2.Descripcion,
                                            @checked = itemHijos2.Permiso != 0 ? true : false,
                                            hasChildren = false
                                        });
                                    }
                                }
                            }
                            
                            resultChildren.Add(new treeView()
                            {
                                id = itemHijos.Id,
                                population = 1,
                                text = itemHijos.Descripcion,
                                flagUrl = itemHijos.Descripcion,
                                @checked = itemHijos.Permiso != 0 ? true : false,
                                hasChildren = false,
                                children = resultChildren2
                            });
                            
                        }
                    }
                }
                if (item.IdFuncionalidad == 0)
                {
                    result.Add(new treeView()
                    {
                        id = item.Id,
                        population = 1,
                        text = item.Descripcion,
                        flagUrl = item.Descripcion,
                        @checked = item.Permiso != 0 && item.Hijos == 0 ? true : false,
                        hasChildren = resultChildren.Count() != 0 ? true : false,
                        children = resultChildren
                    });
                }
            }

            return result;
        }

        public async Task<bool> guardarRolFuncionalidad(valoresRolFuncionalidad valoresRolFunc)
        {
            bool result = false;
            bool resultEliminar = false;
            RolDal db = new RolDal();

            try
            {
                resultEliminar = await db.eliminarRolFuncionalidad(valoresRolFunc);
                if (resultEliminar)
                {
                    if (valoresRolFunc.ids != null)
                    {
                        if (valoresRolFunc.ids.Count != 0)
                        {
                            foreach (var item in valoresRolFunc.ids)
                            {
                                result = await db.guardarRolFuncionalidad(item, valoresRolFunc);
                            }
                        }
                    }
                    else
                    {
                        result = true;
                    }
                }
                else
                {
                    result = false;
                }
                    
            }
            catch (Exception ex)
            {
               Log.RegistrarLogAsync("<<RolBL.ListFuncionalidades>> Error al recuperar datos RolDal.recuperarFuncionalidad", ex.ToString());
            }

            return result;
        }

        public async Task<List<Rol>> recuperarRolPaises()
        {
            RolDal db = new RolDal();
            var listarRolUsuario = new List<Rol>();
            try
            {
                listarRolUsuario = await db.recuperarRolPaises();
            }
            catch (Exception ex)
            {
                listarRolUsuario.Add(new Rol
                {
                    Message = "No se pudieron recuperar datos de Paises."
                });
                Log.RegistrarLogAsync("<<RolBL.recuperarRolPaises>> Error al recuperar datos RolDal.recuperarRolPaises", ex.ToString());
            }

            return listarRolUsuario;
        }
    }
}
