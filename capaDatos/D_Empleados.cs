using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using capaEntidad;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class D_Empleados
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable D_listado()  //Listar Datos
        {
            SqlCommand cmd = new SqlCommand("sp_listar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void D_insertar(E_Empleados emp) //insertar Datos (recibe la clase E_Empleados como parametro)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //llenado de los parametros del procedimiento almacenado (estos se colocan con "@" 
            //y se llenan con el valor ingresado despues de la coma.  "@nom", emp.nom
            cmd.Parameters.AddWithValue("@nom", emp.nom);
            cmd.Parameters.AddWithValue("@edad", emp.edad);
            cmd.Parameters.AddWithValue("@sexo", emp.sexo);
            cmd.Parameters.AddWithValue("@sue", emp.sueldo);

            if (cn.State == ConnectionState.Open) cn.Close();

            cn.Open();
            cmd.ExecuteNonQuery(); // Ejecutar la consulta en el procedimiento almacenado
            cn.Close();
        }

        public void D_eliminar(E_Empleados emp)
        {
            SqlCommand cmd = new SqlCommand("sp_eliminar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //llenado de los parametros del procedimiento almacenado (estos se colocan con "@" 
            //y se llenan con el valor ingresado despues de la coma.  "@cod", emp.cod
            cmd.Parameters.AddWithValue("@cod", emp.cod);

            if (cn.State == ConnectionState.Open) cn.Close();

            cn.Open();
            cmd.ExecuteNonQuery(); // Ejecutar la consulta en el procedimiento almacenado
            cn.Close();
        }


    }
}
