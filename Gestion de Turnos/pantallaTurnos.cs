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
using System.Media;

namespace Gestion_de_Turnos
{
    public partial class pantallaTurnos : Form
    {
        Turno turno = new Turno();
        List<Turno> lista = new List<Turno>();

        public pantallaTurnos()
        {
            InitializeComponent();
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            c4.Text = "";
            c5.Text = "";

            v1.Text = "";
            v2.Text = "";
            v3.Text = "";
            v4.Text = "";
            v5.Text = "";
        }

        private void actualizar()
        {
            try
            {
                //Para Línea 1
                if (lista[1].peso == 1)
                {

                }
            }
            catch
            {

            }
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

        void notificacion() 
        { 
            SoundPlayer player = new SoundPlayer(Properties.Resources.Turno);
            player.Play();
        }
    }
}
