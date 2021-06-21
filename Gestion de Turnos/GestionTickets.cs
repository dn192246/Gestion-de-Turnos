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
    public partial class GestionTickets : Form
    {
        public GestionTickets()
        {
            InitializeComponent();
            actualizarGrid();

            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            txtMesa.Enabled = true;
        }

        Turno turno = null;

        void actualizarGrid()
        {
            Conexion cn = new Conexion();
            if (cn.obtenerTurnoPróximo() == null)
            {
                lbTurno.Text = "-En Espera-";
            }
            else
            {
                turno = cn.obtenerTurnoPróximo();

                string next = "";

                if (turno.peso == 1)
                {
                    next += "CP";
                }
                if (turno.peso == 2)
                {
                    next += "CM";
                }
                if (turno.peso == 3)
                {
                    next += "CN";
                }

                next += turno.numero.ToString();
                lbTurno.Text = next;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (txtMesa.Text == "")
            {
                MessageBox.Show("Debe colocar un número de mesa o " +
                    "ventana de atención", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Conexion cnn = new Conexion();
                try
                {
                    cnn.llamarCliente(int.Parse(txtMesa.Text),
                    turno.numero);
                }
                catch
                {
                    MessageBox.Show("Se produjo un error, intente nuevamente",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            txtMesa.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            txtMesa.Enabled = true;
        }

        private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
