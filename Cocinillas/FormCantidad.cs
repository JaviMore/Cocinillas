using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocinillas
{
    public partial class FormCantidad : Form
    {
        public int cantidad;

        public FormCantidad()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad = Convert.ToInt32(textBoxCantidad.Text);
            }catch(System.FormatException){
                MessageBox.Show("Valor no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
