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
            this.textBoxRUN.Text = "";
            this.maskedTextPass.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.MiUsuario = new Usuario(this.textBoxRUN.Text, this.maskedTextPass.Text);
            this.MiUsuario.Validar();
        }
    }
}
