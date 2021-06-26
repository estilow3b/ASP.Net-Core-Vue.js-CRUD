using Layer.Aplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Layer.Aplication.Helper
{
    public class ProductoAccessData
    {
        public static List<ProductoModel> Listar()
        {
            var lista = new List<ProductoModel>();
            string cadenaConexion = "Data Source=MORALES\\SQL2012;DataBase=BD_Empresa;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Producto_Listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drlector = cmd.ExecuteReader();


            while (drlector.Read())
            {
                ProductoModel oProductoModel = new ProductoModel();
                oProductoModel.CodiProducto = Convert.ToInt32(drlector["Codi_Producto"]);
                oProductoModel.DescripcionProducto = drlector["Descripcion_Producto"].ToString().Trim();
                oProductoModel.CantidadProducto = Convert.ToInt32(drlector["Cantidad_Producto"].ToString().Trim());
                oProductoModel.PrecioProducto = Convert.ToDecimal(drlector["Precio_Producto"].ToString().Trim());
                oProductoModel.Activo = Convert.ToBoolean(drlector["Activo"]);
                lista.Add(oProductoModel);
            }
            return lista;
        }

        public static List<ProductoModel> Filtrar(ProductoModel entidad)
        {
            var lista = new List<ProductoModel>();
            string cadenaConexion = "Data Source=MORALES\\SQL2012;DataBase=BD_Empresa;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Producto_Filtrar", cn);
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", SqlDbType.VarChar, 100)).Value = entidad.DescripcionProducto;

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader drlector = cmd.ExecuteReader();


            while (drlector.Read())
            {
                ProductoModel oProductoModel = new ProductoModel();
                oProductoModel.CodiProducto = Convert.ToInt32(drlector["Codi_Producto"]);
                oProductoModel.DescripcionProducto = drlector["Descripcion_Producto"].ToString().Trim();
                oProductoModel.CantidadProducto = Convert.ToInt32(drlector["Cantidad_Producto"].ToString().Trim());
                oProductoModel.PrecioProducto = Convert.ToDecimal(drlector["Precio_Producto"].ToString().Trim());
                oProductoModel.Activo = Convert.ToBoolean(drlector["Activo"]);
                lista.Add(oProductoModel);
            }
            return lista;
        }

        public static string Registrar(ProductoModel entidad)
        {
            string cadenaConexion = "Data Source=MORALES\\SQL2012;DataBase=BD_Empresa;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Producto_Registrar", cn);
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", SqlDbType.VarChar, 100)).Value = entidad.DescripcionProducto;
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Producto", SqlDbType.Int)).Value = entidad.CantidadProducto;
            cmd.Parameters.Add(new SqlParameter("@Precio_Producto", SqlDbType.Decimal)).Value = entidad.PrecioProducto;
            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.VarChar, 100)).Value = entidad.Activo;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Registro Exitoso";

        }

        public static string Modificar(ProductoModel entidad)
        {
            string cadenaConexion = "Data Source=MORALES\\SQL2012;DataBase=BD_Empresa;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Producto_Modificar", cn);
            cmd.Parameters.Add(new SqlParameter("@Codi_Producto", SqlDbType.Int)).Value = entidad.CodiProducto;
            cmd.Parameters.Add(new SqlParameter("@Descripcion_Producto", SqlDbType.VarChar, 100)).Value = entidad.DescripcionProducto;
            cmd.Parameters.Add(new SqlParameter("@Cantidad_Producto", SqlDbType.Int)).Value = entidad.CantidadProducto;
            cmd.Parameters.Add(new SqlParameter("@Precio_Producto", SqlDbType.Decimal)).Value = entidad.PrecioProducto;
            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.VarChar, 100)).Value = entidad.Activo;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Modificación Exitosa";

        }

        public static string Eliminar(int id)
        {
            string cadenaConexion = "Data Source=MORALES\\SQL2012;DataBase=BD_Empresa;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("usp_Producto_Eliminar", cn);
            cmd.Parameters.Add(new SqlParameter("@Codi_Producto", SqlDbType.Int)).Value = id;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Eliminación Exitosa";

        }
    }
}
