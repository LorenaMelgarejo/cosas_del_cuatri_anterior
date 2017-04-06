using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculadora_2017;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text ="";
            textNumero1.Text = "";
            textNumero2.Text = "";
            cmbOperacion.Text = "";
        }
             
            
        private void texNumero1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnOperar_click(object sender, EventArgs e)
        { 
            
            Numero Nv1 =new Numero(this.textNumero1.Text);
            Numero Nv2 = new Numero(this.textNumero2.Text);

            this.lblResultado.Text = Calculadora.operar(Nv1, Nv2, cmbOperacion.Text).ToString();
            this.lblResultado.Visible = true;
       
   
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      


        
    }
}
