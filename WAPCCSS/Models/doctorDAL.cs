using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WAPCCSS.Models
{
    public class doctorDAL
    {   
        SqlConnection con = new SqlConnection("Data Source=10.60.0.169;Initial Catalog=dbDesarrollo;User ID=desa;Password=Desa.123");
        public string AgregarDoctor(entDoctor doctor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ins_doctor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", doctor.codigo);
                cmd.Parameters.AddWithValue("@cedula", doctor.cedula);
                cmd.Parameters.AddWithValue("@nombre", doctor.nombre);
                cmd.Parameters.AddWithValue("@apellido1", doctor.apellido1);
                cmd.Parameters.AddWithValue("@apellido2", doctor.apellido2);
                cmd.Parameters.AddWithValue("@email", doctor.email);
                cmd.Parameters.AddWithValue("@fk_pais", doctor.pais);
                cmd.Parameters.AddWithValue("@fk_provincia", doctor.provincia);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Doctor agregado satisfactoriamente");
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
        public DataTable BuscarDoctor(entDoctor doctor)
        {
            try
            {
                //SqlCommand cmd = new SqlCommand("Select * from vdoctores where codigo=@codigo", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@codigo", doctor.codigo);                
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                //return ("Doctor agregado satisfactoriamente");
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from vdoctores where codigo=@codigo", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codigo", doctor.codigo);                
                con.Open();
                
                //con.Close();
                //return ("Doctor agregado satisfactoriamente");


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