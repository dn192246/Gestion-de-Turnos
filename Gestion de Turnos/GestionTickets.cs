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
        }

        void actualizarGrid()
        {
            Conexion cn = new Conexion();
            if (cn.obtenerTurnoPróximo() == "")
            {
                lbTurno.Text = "-En Espera-";
            }
            else
            {
                lbTurno.Text = cn.obtenerTurnoPróximo();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarGrid();
        }
    }
}
