using MOD.RenoExpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RenoExpress.DAL
{
    public class DatosProductosDAL
    {
        public string SqlconString = "Data Source=svn-desa.cloudapp.net;Initial Catalog=RenoExpressPruebas;User ID=programador;Password=programador";//Hizo falta la encriptación y el uso de owin
        public DataTable GetProductosDAL()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conexion = new SqlConnection(SqlconString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("[SP_GetProductos]", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productoEspecifico", "");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

            }
            return dt;
        }

        public bool RealizarCompraDAL(Compra compra)
        {
            DataTable dt = new DataTable();
            string codigoCompra = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(SqlconString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("[SP_IngresaCompra]", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", compra.nombreCompra);
                    cmd.Parameters.AddWithValue("@observaciones", compra.observacionCompra);
                    cmd.Parameters.AddWithValue("@fecha", compra.fechaCompra);
                    cmd.Parameters.AddWithValue("@usuarioID", compra.usuarioID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conexion.Close();
                }
                codigoCompra = dt.Rows[0]["id"].ToString();

                foreach(var item in compra.detalleCompra)
                {
                    using (SqlConnection conexion = new SqlConnection(SqlconString))
                    {
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand("[SP_IngresaCompraDte]", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompraID", codigoCompra);
                        cmd.Parameters.AddWithValue("@ProdID", item.ProdID);
                        cmd.Parameters.AddWithValue("@CantidadCompraDte", item.cantidadDte);
                        cmd.Parameters.AddWithValue("@PrecioCompraDte", item.precioCompraDte);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        conexion.Close();
                    }
                }
                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }

        public bool RealizarVentaDAL(Venta venta)
        {
            DataTable dt = new DataTable();
            string codigoVenta = string.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(SqlconString))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("[SP_IngresaVenta]", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", venta.nombreVenta);
                    cmd.Parameters.AddWithValue("@observaciones", venta.observacionVenta);
                    cmd.Parameters.AddWithValue("@fecha", venta.fechaVenta);
                    cmd.Parameters.AddWithValue("@usuarioID", venta.usuarioID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    conexion.Close();
                }
                codigoVenta = dt.Rows[0]["id"].ToString();

                foreach (var item in venta.detalleVenta)
                {
                    using (SqlConnection conexion = new SqlConnection(SqlconString))
                    {
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand("[SP_IngresaVentaDte]", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@VentaID", codigoVenta);
                        cmd.Parameters.AddWithValue("@ProdID", item.ProdID);
                        cmd.Parameters.AddWithValue("@CantidadventaDte", item.cantidadDte);
                        cmd.Parameters.AddWithValue("@PrecioVentaDte", item.precioVentaDte);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        conexion.Close();
                    }
                }
                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }
    }
}

