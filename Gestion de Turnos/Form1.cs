using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Turnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpantalla_Click(object sender, EventArgs e)
        {
            pantallaTurnos turnos = new pantallaTurnos();
            turnos.Show();
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            GestionTickets gt = new GestionTickets();
            gt.Show();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            tickets T = new tickets();
            T.Show();
        }

		private void btnClientes_Click(object sender, EventArgs e)
		{
			if (Program.nivel == 2)
			{
				MessageBox.Show("No tiene los permisos suficientes para acceder a esta función", "No autorizado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			else
			{
				Clientes cl = new Clientes();
				cl.Show();
			}				
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			if (Program.nivel == 2)
			{
				MessageBox.Show("No tiene los permisos suficientes para acceder a esta función", "No autorizado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			else
			{
				Usuarios usu = new Usuarios();
				usu.Show();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//MessageBox.Show(Program.nivel.ToString());
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Sesion ses = new Sesion();
			ses.Show();
		}
	}
}
