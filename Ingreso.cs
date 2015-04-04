using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocusContulmo.Clases;

namespace DocusContulmo
{
    public partial class Ingreso : Form
    {
        private Usuario MiUsuario;

        public Ingreso()
        {
            InitializeComponent();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBoxRUN.Text = "";
            textBoxPass.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            MiUsuario = new Usuario(textBoxRUN.Text, textBoxPass.Text);
            MiUsuario.Validar();
        }
    }
}
