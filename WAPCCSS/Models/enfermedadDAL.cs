using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAPCCSS.Models
{
    public class enfermedadDAL    
    {
        SqlConnection con = new SqlConnection("Data Source=10.60.0.169;Initial Catalog=dbDesarrollo;User ID=desa;Password=Desa.123");
        public string AgregarEnfermedad(entEnfermedad enfermedad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ins_sintoma", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fk_paciente", enfermedad.paciente);
                cmd.Parameters.AddWithValue("@fk_sintoma", enfermedad.sintoma);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Sintoma agregado satisfactoriamente");
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
    }
}