using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Conexion
    {

        static string conexionstring = "server= localhost;database= RestauranteRenuevo;" +
            "integrated security=true";

        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario) 
        {
            int count;
            con.Open();
            string Query = "Select Count(*) From Operador where usuario='" + Usuario + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();


            return count;
        }




    }
}
