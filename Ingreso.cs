﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocusContulmo
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.textBoxRUN.Text = "";
            this.textBoxContraseña.Text = "";
        }
    }
}
