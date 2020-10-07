using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_WorkshopSena
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
            Pnl_Inicio.Visible = true;
            Pnl_Usuario.Visible = false;
            Pnl_Contraseña.Visible = false;
            Pnl_Inicio.Location = new Point(15, 219);
            Pnl_Inicio.Size = new Size(366, 240);
        }

        private void Ptb_Usuario_Click(object sender, EventArgs e)
        {
            Pnl_Inicio.Visible = false;
            Pnl_Usuario.Visible = true;
            Pnl_Usuario.Location = new Point(15, 219);
            Pnl_Usuario.Size = new Size(366, 240);
        }

        private void Ptb_Contraseña_Click(object sender, EventArgs e)
        {
            Pnl_Inicio.Visible = false;
            Pnl_Usuario.Visible = false;
            Pnl_Contraseña.Visible = true;
            Pnl_Contraseña.Location = new Point(15, 219);
            Pnl_Contraseña.Size = new Size(366, 240);
        }

        private void Ptb_Info_Click(object sender, EventArgs e)
        {
            Pnl_Inicio.Visible = true;
            Pnl_Usuario.Visible = false;
            Pnl_Contraseña.Visible = false;
            Pnl_Contraseña.Location = new Point(15, 219);
            Pnl_Contraseña.Size = new Size(366, 240);
        }


        private void TxtId__Enter(object sender, EventArgs e)
        {
            if (TxtId_.Text == "Nro. Identificacion")
            {
                TxtId_.Text = "";
                TxtId_.ForeColor = Color.DimGray;
            }
        }

        private void TxtId__Leave(object sender, EventArgs e)
        {
            if (TxtId_.Text == "")
            {
                TxtId_.Text = "Nro. Identificacion";
                TxtId_.ForeColor = Color.DimGray;
            }
        }

        private void TxtCorreo_Enter(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "Correo electronico")
            {
                TxtCorreo.Text = "";
                TxtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "Correo electronico";
                TxtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void TxtIdentificacion_Enter(object sender, EventArgs e)
        {
            if (TxtIdentificacion.Text == "Nro. Identificacion")
            {
                TxtIdentificacion.Text = "";
                TxtIdentificacion.ForeColor = Color.DimGray;
            }
        }

        private void TxtIdentificacion_Leave(object sender, EventArgs e)
        {
            if (TxtIdentificacion.Text == "")
            {
                TxtIdentificacion.Text = "Nro. Indetificacion";
                TxtIdentificacion.ForeColor = Color.DimGray;
            }
        }

        private void TxtDocumento_Enter(object sender, EventArgs e)
        {
            if (TxtDocumento.Text == "Nro. Identificacion")
            {
                TxtDocumento.Text = "";
                TxtDocumento.ForeColor = Color.DimGray;
            }
        }

        private void TxtDocumento_Leave(object sender, EventArgs e)
        {
            if (TxtDocumento.Text == "")
            {
                TxtDocumento.Text = "Nro. Indetificacion";
                TxtDocumento.ForeColor = Color.DimGray;
            }
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Usuario")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "")
            {
                TxtUser.Text = "Usuario";
                TxtUser.ForeColor = Color.DimGray;
            }
        }
    }
}
