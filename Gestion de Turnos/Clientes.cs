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
	public partial class Clientes : Form
	{
		string user = "user id=db_a74adc_ads2021_admin;";
		string pass = "password=2021ads01;";
		string db = "Initial Catalog=db_a74adc_ads2021;";
		string source = "Data source= SQL5068.site4now.net;";

		

		public Clientes()
		{
			InitializeComponent();
		}

		private void Clientes_Load(object sender, EventArgs e)
		{
			actualizarGrid();
		}

		public void actualizarGrid()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT idmiembro as " +
				"'DUI', nombre as 'Nombre', peso as 'Nivel de Prioridad' FROM Miembro",
				"server = SQL5068.site4now.net; database = db_a74adc_ads2021; " +
				"UID = db_a74adc_ads2021_admin; password = 2021ads01");
			DataSet ds = new DataSet();
			da.Fill(ds, "Miembro");
			dgvClientes.DataSource = ds.Tables["Miembro"].DefaultView;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string cadena = source + db + user + pass;

			Conexion cn = new Conexion();
			try
			{
				string cadena2 = cn.CadenaConexion();
				string consulta = "SELECT * FROM miembro";
				SqlConnection con = new SqlConnection(cadena);
				SqlCommand cmd2 = new SqlCommand(consulta, con);

				con.Open();
				SqlDataReader drd = cmd2.ExecuteReader();
				while (drd.Read())
				{
					if (drd["idmiembro"].ToString() == mtxtDUI.Text)
					{
						MessageBox.Show("El DUI ingresado ya existe");
						drd.Close();
						con.Close();
						return;
					}
					
				}

			}
			catch
			{
				MessageBox.Show("Error ");
			}
			

				SqlConnection conx = new SqlConnection(cadena);
				string com = "insert into miembro (idmiembro,nombre,peso) " +
					"values (@id, @nom, @pes);";
				conx.Open();
				SqlCommand cmd = new SqlCommand(com, conx);

				cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar));
				cmd.Parameters["@id"].Value = mtxtDUI.Text;

				cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar));
				cmd.Parameters["@nom"].Value = txtNombre.Text;

			if (rbMiem.Checked == true)
				{
				cmd.Parameters.Add(new SqlParameter("@pes", SqlDbType.VarChar));
				cmd.Parameters["@pes"].Value = "2";
				}
			else if(rbPrio.Checked == true)
			{
				cmd.Parameters.Add(new SqlParameter("@pes", SqlDbType.VarChar));
				cmd.Parameters["@pes"].Value = "1";
			}
			else
			{
				MessageBox.Show("Seleccione el tipo de miembro que será el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				conx.Close();
				actualizarGrid();
				
				return;
			}


			cmd.ExecuteNonQuery();
				conx.Close();
			actualizarGrid();
			mtxtDUI.Text = "";
			txtNombre.Text = "";
			rbMiem.Checked = false;
			rbPrio.Checked = false;

		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Conexion cn = new Conexion();
			string cadena = cn.CadenaConexion();
			string consulta = "DELETE FROM miembro WHERE idmiembro = @id";
			SqlConnection con = new SqlConnection(cadena);
			SqlCommand cmd = new SqlCommand(consulta, con);
			cmd.Parameters.AddWithValue("@id", (string)dgvClientes[0, dgvClientes.CurrentRow.Index].Value);

			try
			{
				con.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Cliente eliminado",
					"Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Hubo un error, intente nuevamente",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Close();
			}
			actualizarGrid();
		}

		private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != ('-')))
			{
				e.Handled = true;
				return;
			}


			if (e.KeyChar == ('-'))
			{
				if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
					e.Handled = true;
			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(mtxtDUI.Text);
		}

		private void mtxtDUI_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
