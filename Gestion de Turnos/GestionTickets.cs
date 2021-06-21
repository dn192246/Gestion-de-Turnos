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
            actualizar();

            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            txtMesa.Enabled = true;
        }

        Heap cola = new Heap();
        Turno turno = null;

        void actualizar()
        {
            Conexion cn = new Conexion();

            string cadena = cn.source + cn.db + cn.user + cn.pass;
            SqlConnection conx = new SqlConnection(cadena);

            SqlConnection conx1 = new SqlConnection(cadena);

            string com1 = "select * from turno where estado=0";
            string com2 = "update turno set estado=1 where id=@id";

            SqlDataReader rd;
            conx.Open();
            SqlCommand cmd1 = new SqlCommand(com1, conx);
         

            rd = cmd1.ExecuteReader();

            while (rd.Read())
            {
                Turno turno = new Turno();
                int id = int.Parse(rd[0].ToString());

                turno.peso = int.Parse(rd[1].ToString());

                turno.numero = int.Parse(id.ToString());
                

                SqlCommand cmd2 = new SqlCommand(com2, conx1);
                conx1.Open();

                cmd2.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                cmd2.Parameters["@id"].Value = id;

                cmd2.ExecuteNonQuery();

                cola.InsertElementInHeap(turno);
                conx1.Close();               
            }
            conx.Close();

            Turno turnoMuestra = cola.PeekOfHeap();
            string next = "";

            if (turnoMuestra != null)
            {
                if (turnoMuestra.peso == 1)
                {
                    next += "CP";
                }

                if (turnoMuestra.peso == 2)
                {
                    next += "CM";
                }

                if (turnoMuestra.peso == 3)
                {
                    next += "CN";
                }

                next += turnoMuestra.numero;
            }
            
            if(next == "")
            {
                lbTurno.Text = "-En Espera-";
            }
            else
            {
                lbTurno.Text = next;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizar();
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
