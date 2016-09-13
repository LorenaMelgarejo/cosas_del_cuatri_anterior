namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IblResultado = new System.Windows.Forms.Label();
            this.texNumero1 = new System.Windows.Forms.TextBox();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IblResultado
            // 
            this.IblResultado.AutoSize = true;
            this.IblResultado.Location = new System.Drawing.Point(16, 21);
            this.IblResultado.Name = "IblResultado";
            this.IblResultado.Size = new System.Drawing.Size(19, 13);
            this.IblResultado.TabIndex = 0;
            this.IblResultado.Text = "00";
            // 
            // texNumero1
            // 
            this.texNumero1.Location = new System.Drawing.Point(12, 93);
            this.texNumero1.Name = "texNumero1";
            this.texNumero1.Size = new System.Drawing.Size(96, 20);
            this.texNumero1.TabIndex = 1;
            this.texNumero1.TextChanged += new System.EventHandler(this.texNumero1_TextChanged);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(114, 92);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(56, 21);
            this.cmbOperacion.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(33, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "cc";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(159, 159);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(95, 19);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "=";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(176, 93);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(96, 20);
            this.textNumero2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.texNumero1);
            this.Controls.Add(this.IblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblResultado;
        private System.Windows.Forms.TextBox texNumero1;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox textNumero2;
    }
}

