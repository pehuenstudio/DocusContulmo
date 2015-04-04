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
        private Usuario usuario;

        public Ingreso()
        {
            InitializeComponent();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.textBoxRUN.Text = "";
            this.textBoxContraseña.Text = "";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.usuario = new Usuario(this.textBoxRUN.Text, this.textBoxContraseña.Text);
            this.usuario.ValidarUsuario();
        }
    }
}
