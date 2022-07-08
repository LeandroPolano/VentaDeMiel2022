﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes() { Text = "Clientes" };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void PaisButton_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais() { Text = "Paises" };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TipoEnvaseButton_Click(object sender, EventArgs e)
        {
            FrmTipoEnvase frm = new FrmTipoEnvase() { Text = "Envases" };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
