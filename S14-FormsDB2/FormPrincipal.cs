using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S14_FormsDB2
{
    public partial class FormPrincipal : Form
    {
        FormCategorias formularioCategorias;
        FormProductos formularioProductos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioCategorias = new FormCategorias();
            formularioCategorias.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioProductos = new FormProductos();
            formularioProductos.ShowDialog();

            //Se puede acceder a cualquier campo declarado public del formulario PRODUCTOS
            //formularioProductos.valor;
            
        }
    }
}
