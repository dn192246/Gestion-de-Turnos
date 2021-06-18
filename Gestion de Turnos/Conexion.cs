using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_de_Turnos
{
    class Conexion
    {      
            public string user = "user id=db_a74adc_ads2021_admin;";
            public string pass = "password=2021ads01;";
            public string db = "Initial Catalog=db_a74adc_ads2021;";
            public string source = "Data source= SQL5068.site4now.net;";

        public void agregarTurno(int peso)
        {
            string cadena = source + db + user + pass;
            SqlConnection conx = new SqlConnection(cadena);
            string com = "insert into turno(peso, estado) " +
                "values (@peso,0);";
            conx.Open();
            SqlCommand cmd = new SqlCommand(com, conx);

            cmd.Parameters.Add(new SqlParameter("@peso", SqlDbType.Int));
            cmd.Parameters["@peso"].Value = peso;

            cmd.ExecuteNonQuery();
            conx.Close();
        }

        public void reiniciar()
        {
            string cadena = source + db + user + pass;
            SqlConnection conx = new SqlConnection(cadena);
            string com = "delete from turno;DBCC CHECKIDENT ('turno',reseed, 0);";
            conx.Open();
            SqlCommand cmd = new SqlCommand(com, conx);

            cmd.ExecuteNonQuery();
            conx.Close();
        }

        public string obtenerTurnoPróximo()
        {
            string cadena = source + db + user + pass;
            SqlConnection conx = new SqlConnection(cadena);
            string com = "select top 1 * from turno where estado=0 order by peso asc";
            SqlDataReader rd;
            conx.Open();
            SqlCommand cmd = new SqlCommand(com, conx);

            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string respuesta = "";
                int id = int.Parse(rd[0].ToString());

                if (rd[1].ToString() == "1")
                {
                    respuesta += "CP";
                }
                if (rd[1].ToString() == "2")
                {
                    respuesta += "CM";
                }
                if (rd[1].ToString() == "3")
                {
                    respuesta += "CN";
                }

                respuesta += id.ToString();
                conx.Close();
                return respuesta;
            }
            else
            {
                conx.Close();
                return "";
            }
        }
    }
}
