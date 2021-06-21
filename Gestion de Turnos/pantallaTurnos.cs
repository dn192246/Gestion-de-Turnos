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
    public partial class pantallaTurnos : Form
    {
        public pantallaTurnos()
        {
            InitializeComponent();
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            c4.Text = "";
            c5.Text = "";
            c6.Text = "";

            v1.Text = "";
            v2.Text = "";
            v3.Text = "";
            v4.Text = "";
            v5.Text = "";
            v6.Text = "";
        }

        Heap cola = new Heap();

        private void obtenerTurnos()
        {

            string cadena = "user id=db_a74adc_ads2021_admin;"
            + "password=2021ads01;" + "Initial Catalog=db_a74adc_ads2021;"
            + "Data source= SQL5068.site4now.net;";


            SqlConnection conex1 = new SqlConnection(cadena);
            SqlConnection conex = new SqlConnection(cadena);

            string com = "select * from turno where estado=1";
            string com2 = "update turno set estado=2 where id=@id;";

            SqlDataReader rd;
            conex.Open();
            SqlCommand cmd = new SqlCommand(com, conex);

            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Turno turno = new Turno();
                turno.peso = int.Parse(rd[1].ToString());
                turno.numero = int.Parse(rd[0].ToString());       
                
            }
            conex.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar ventana?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.DarkRed;
            btnCerrar.BorderStyle = BorderStyle.None;
        }

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            btnCerrar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnCerrar.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
