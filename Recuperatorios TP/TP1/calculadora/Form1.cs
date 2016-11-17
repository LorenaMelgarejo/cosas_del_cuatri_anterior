using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            IblResultado.Text = "";
            texNumero1.Text = "";
            textNumero2.Text = "";
            cmbOperacion.Text = "";


        }

        private void texNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero Nv1 =new Numero(this.texNumero1.Text);
            Numero Nv2 = new Numero(this.textNumero2.Text);

            this.IblResultado.Text = Calculadora.operar(Nv1, Nv2, cmbOperacion.Text).ToString();
            this.IblResultado.Visible = true;
        }
    }
}
