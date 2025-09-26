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
        {   // Habilito o deshabilito el campo mtbNumero según si el campo txtContacto está vacío o no
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
        {   // Habilito o deshabilito el botón Registrar según si el campo mtbNumero está vacío o no
            if (mtbNumero.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }
        // Variables globales
        string vContacto;
        string vNumero;
        string vContador;
        string vFecha;

        string[] vecTelefono = new string[5];
        string[] vecContacto = new string[5];

        int indice = 0;



        private void btnRegistrar_Click(object sender, EventArgs e)
        {   // Guardo los datos en los vectores
            vecTelefono[indice] = mtbNumero.Text;
            vecContacto[indice] = txtContacto.Text;

            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;
            
            lstResultado.Items.Add("Contacto"+vContacto+"Numero"+vNumero);

            // Limpio los campos de texto
            txtContacto.Text = "";
            mtbNumero.Text = "";


            // Actualizo el contador de contactos
            vContador = vContador + 1;
            mtbCantContactos.Text= Convert.ToString(vContador);


            // Actualizo la fecha y hora del último contacto agregado
            indice++;

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   // Limpio los campos de texto
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmGestionAgenda_Load(object sender, EventArgs e)
        {

            

            btnRegistrar.Enabled = false;
            mtbNumero.Enabled = false;
             
        }

        private void btnListar_Click(object sender, EventArgs e)
        {   // Limpio el ListBox antes de mostrar los contactos
            lstListado.Items.Clear();

            

            // Recorro los vectores y agrego los contactos al ListBox
            for (int i = 0; i < vecContacto.Length; i++)
            {
                if (vecContacto[i] != null)
                {
                    lstListado.Items.Add("Contacto: " + vecContacto[i] + " - Telefono: " + vecTelefono[i]);
                }
            }

        }
    }
    
}
