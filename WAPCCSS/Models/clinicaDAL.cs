using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAPCCSS.Models
{
    public class clinicaDAL
    {
        SqlConnection con = new SqlConnection("Data Source=10.60.0.169;Initial Catalog=dbDesarrollo;User ID=desa;Password=Desa.123");
        public string AgregarClinica(entClinica clinica)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ins_clinica", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@cedula", clinica.cedula);
                cmd.Parameters.AddWithValue("@nombre", clinica.nombre);
                cmd.Parameters.AddWithValue("@fk_pais", clinica.pais);
                cmd.Parameters.AddWithValue("@fk_provincia", clinica.provincia);
                cmd.Parameters.AddWithValue("@fk_distrito", clinica.distrito);
                cmd.Parameters.AddWithValue("@telefono", clinica.telefono);                
                cmd.Parameters.AddWithValue("@email", clinica.email);
                cmd.Parameters.AddWithValue("@sitioweb", clinica.sitioweb);
                
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Clinica agregada satisfactoriamente");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
        public DataTable BuscarClinica(entClinica clinica)
        {
            try
            {                
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from vclinica where codigo=@codigo", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codigo", clinica.codigo);
                con.Open();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (dt);
            }
        }
    }
}