using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Turnos
{
	public partial class Sesion : Form
	{
		public Sesion()
		{
			InitializeComponent();
		}

		string user = "user id=db_a74adc_ads2021_admin;";
		string pass = "password=2021ads01;";
		string db = "Initial Catalog=db_a74adc_ads2021;";
		string source = "Data source= SQL5068.site4now.net;";

		private void btnInicio_Click(object sender, EventArgs e)
		{
			//string cadena = source + db + user + pass;

			Conexion cn = new Conexion();
			try
			{
				string cadena = cn.CadenaConexion();
				string consulta = "SELECT * FROM Usuarios WHERE username = @id";
				SqlConnection con = new SqlConnection(cadena);
				SqlCommand cmd = new SqlCommand(consulta, con);

				cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
				cmd.Parameters["@id"].Value = txtUsuario.Text;

				con.Open();
				SqlDataReader drd = cmd.ExecuteReader();
				while (drd.Read())
				{
					if(drd[0].ToString() != txtUsuario.Text || drd[2].ToString() != txtContra.Text)
					{
						MessageBox.Show("Usuario o contraseña erróneos. En caso de no recordar el acceso, contacte al administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						drd.Close();
						con.Close();
						return;
					}
					else
					{
						Program.nivel = Int32.Parse(drd[3].ToString());
						MessageBox.Show("Bienvenido " + drd[1].ToString(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
						drd.Close();
						con.Close();
						Form1 menu = new Form1();
						menu.Show();
						this.Hide();
					return;
					}
				}

			}
			catch
			{
				MessageBox.Show("Error ");
			}

			
		}

		private void Sesion_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void Sesion_Load(object sender, EventArgs e)
		{

		}
	}
}
