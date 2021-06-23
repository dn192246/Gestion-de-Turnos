using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Turnos
{
    public partial class tickets : Form
    {
        public tickets()
        {
            InitializeComponent();
            actualizarGrid();
            rbnomiembro.Checked=true;
        }

		string user = "user id=db_a74adc_ads2021_admin;";
		string pass = "password=2021ads01;";
		string db = "Initial Catalog=db_a74adc_ads2021;";
		string source = "Data source= SQL5068.site4now.net;";

		private void btngenerar_Click(object sender, EventArgs e)
        {
            if (rbnomiembro.Checked)
            {
                Conexion cn = new Conexion();
                cn.agregarTurno(3);
            }
            if (rbmiembro.Checked)
            {
                Conexion cn = new Conexion();
                cn.agregarTurno(2);
            }
            if (rbprioritario.Checked)
            {
                Conexion cn = new Conexion();
                cn.agregarTurno(1);
            }
			if(rbDUI.Checked)
			{
				int checar = 0;
				string cadena = source + db + user + pass;
				Conexion cn = new Conexion();
				try
				{
					string cadena2 = cn.CadenaConexion();
					string consulta = "SELECT * FROM miembro Where idmiembro = @id";
					SqlConnection con = new SqlConnection(cadena);
					SqlCommand cmd2 = new SqlCommand(consulta, con);
					cmd2.Parameters.AddWithValue("@id", mtxtDUI.Text);

					con.Open();
					SqlDataReader drd = cmd2.ExecuteReader();
					if(drd.HasRows)
					{
						while (drd.Read())
						{
							if (drd["idmiembro"].ToString() == mtxtDUI.Text)
							{
								cn.agregarTurno(Int32.Parse(drd[2].ToString()));
								checar = 1;


							}
							

						}
					}
					else
					{
						drd.Close();
						con.Close();
						MessageBox.Show("Miembro no existente");
					}
					
			
				}
				catch
				{
					MessageBox.Show("Error ");
				}
			}

            actualizarGrid();
        }

        public void actualizarGrid()
        {
            SqlConnection con = new SqlConnection("server = SQL5068.site4now.net; " +
                "database = db_a74adc_ads2021; " +
                "UID = db_a74adc_ads2021_admin; password = 2021ads01");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select peso as Prioridad, " +
                "id as Turno from turno where estado=0 or estado= 1" +
                " order by peso asc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "turnos");
            dgvTurnos.DataSource = ds.Tables["turnos"].DefaultView;
            con.Close();

            foreach (DataGridViewColumn dgvc in dgvTurnos.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea reiniciar el conteo de " +
                "tickets? Esta acción no puede deshacerse", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Conexion cnx = new Conexion();
                try
                {
                    cnx.reiniciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    actualizarGrid();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
