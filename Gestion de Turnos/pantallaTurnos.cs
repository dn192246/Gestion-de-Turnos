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
    public partial class pantallaTurnos : Form
    {
        public pantallaTurnos()
        {
            InitializeComponent();
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
