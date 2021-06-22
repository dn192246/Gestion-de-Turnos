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
	public partial class Usuarios : Form
	{
		public Usuarios()
		{
			InitializeComponent();
		}

		private void Usuarios_Load(object sender, EventArgs e)
		{

		}

		public void actualizarGrid()
		{
			SqlDataAdapter da = new SqlDataAdapter("SELECT idmiembro as " +
				"'DUI', nombre as 'Nombre', peso as 'Nivel de Prioridad' FROM Miembro",
				"server = SQL5068.site4now.net; database = db_a74adc_ads2021; " +
				"UID = db_a74adc_ads2021_admin; password = 2021ads01");
			DataSet ds = new DataSet();
			da.Fill(ds, "Miembro");
			dgvUsuarios.DataSource = ds.Tables["Miembro"].DefaultView;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

		}
	}
}
