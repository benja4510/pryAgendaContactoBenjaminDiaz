using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaContactoBenjaminDiaz
{
    public partial class frmGestionAgenda : Form
    {
        public frmGestionAgenda()
        {
            InitializeComponent();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mtbNumero.Enabled = false;
            }
            else
            {
                mtbNumero.Enabled = true;
            }
            
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        string vContacto;
        string vNumero;
        string vContador;
        string vFecha;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;
            lstResultado.Items.Add("Contacto"+vContacto+"Numero"+vNumero);
            txtContacto.Text = "";
            mtbNumero.Text = "";
            vContador = vContador+1;
            lblCantidadCon.Text = "Cantidad de contactos: "+vContador;
            lblFechayHora.Text = "Fecha y hora:" +vFecha;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
