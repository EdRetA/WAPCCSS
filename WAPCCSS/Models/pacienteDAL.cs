using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAPCCSS.Models
{
    public class pacienteDAL
    {
        SqlConnection con = new SqlConnection("Data Source=10.60.0.169;Initial Catalog=dbDesarrollo;User ID=desa;Password=Desa.123");
        public string AgregarPaciente(entPaciente paciente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ins_paciente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cedula", paciente.cedula);
                cmd.Parameters.AddWithValue("@nombre", paciente.nombre);
                cmd.Parameters.AddWithValue("@apellido1", paciente.apellido1);
                cmd.Parameters.AddWithValue("@apellido2", paciente.apellido2);
                //cmd.Parameters.AddWithValue("@fechanacimiento", paciente.fechanacimiento);
                cmd.Parameters.AddWithValue("@genero", paciente.genero);
                cmd.Parameters.AddWithValue("@contacto", paciente.contacto);
                cmd.Parameters.AddWithValue("@fk_pais", paciente.pais);
                cmd.Parameters.AddWithValue("@fk_provincia", paciente.provincia);
                cmd.Parameters.AddWithValue("@fk_distrito", paciente.distrito);
                cmd.Parameters.AddWithValue("@fk_estadocivil", paciente.estadocivil);
                cmd.Parameters.AddWithValue("@telefono", paciente.telefono);
                cmd.Parameters.AddWithValue("@email", paciente.email);
                //cmd.Parameters.AddWithValue("@registro", paciente.fecharegistro);
                cmd.Parameters.AddWithValue("@ocupacion", paciente.ocupacion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Paciente agregado satisfactoriamente");
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
        public DataTable BuscarPaciente(entPaciente paciente)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from vpacientes where cedula=@cedula", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cedula", paciente.cedula);
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