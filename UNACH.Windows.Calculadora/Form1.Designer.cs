namespace UNACH.Windows.Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXBA = new System.Windows.Forms.TextBox();
            this.TXBB = new System.Windows.Forms.TextBox();
            this.CBOperacion = new System.Windows.Forms.ComboBox();
            this.IGUAL = new System.Windows.Forms.Label();
            this.TXBResultado = new System.Windows.Forms.TextBox();
            this.BTNBorrar = new System.Windows.Forms.Button();
            this.BTNResultado = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TXBA
            // 
            this.TXBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBA.Location = new System.Drawing.Point(26, 133);
            this.TXBA.Name = "TXBA";
            this.TXBA.Size = new System.Drawing.Size(100, 26);
            this.TXBA.TabIndex = 1;
            this.TXBA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBA_KeyPress);
            // 
            // TXBB
            // 
            this.TXBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBB.Location = new System.Drawing.Point(215, 133);
            this.TXBB.Name = "TXBB";
            this.TXBB.Size = new System.Drawing.Size(100, 26);
            this.TXBB.TabIndex = 2;
            // 
            // CBOperacion
            // 
            this.CBOperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOperacion.FormattingEnabled = true;
            this.CBOperacion.Items.AddRange(new object[] {
            "*",
            "/",
            "+",
            "-"});
            this.CBOperacion.Location = new System.Drawing.Point(146, 125);
            this.CBOperacion.Name = "CBOperacion";
            this.CBOperacion.Size = new System.Drawing.Size(46, 32);
            this.CBOperacion.TabIndex = 3;
            // 
            // IGUAL
            // 
            this.IGUAL.AutoSize = true;
            this.IGUAL.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGUAL.Location = new System.Drawing.Point(338, 125);
            this.IGUAL.Name = "IGUAL";
            this.IGUAL.Size = new System.Drawing.Size(38, 34);
            this.IGUAL.TabIndex = 4;
            this.IGUAL.Text = "=";
            // 
            // TXBResultado
            // 
            this.TXBResultado.Enabled = false;
            this.TXBResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBResultado.Location = new System.Drawing.Point(393, 133);
            this.TXBResultado.Name = "TXBResultado";
            this.TXBResultado.Size = new System.Drawing.Size(100, 26);
            this.TXBResultado.TabIndex = 5;
            // 
            // BTNBorrar
            // 
            this.BTNBorrar.Location = new System.Drawing.Point(224, 244);
            this.BTNBorrar.Name = "BTNBorrar";
            this.BTNBorrar.Size = new System.Drawing.Size(75, 23);
            this.BTNBorrar.TabIndex = 6;
            this.BTNBorrar.Text = "Borrar";
            this.BTNBorrar.UseVisualStyleBackColor = true;
            this.BTNBorrar.Click += new System.EventHandler(this.BTNBorrar_Click);
            // 
            // BTNResultado
            // 
            this.BTNResultado.Location = new System.Drawing.Point(278, 200);
            this.BTNResultado.Name = "BTNResultado";
            this.BTNResultado.Size = new System.Drawing.Size(75, 23);
            this.BTNResultado.TabIndex = 7;
            this.BTNResultado.Text = "Resultado";
            this.BTNResultado.UseVisualStyleBackColor = true;
            this.BTNResultado.Click += new System.EventHandler(this.BTNResultado_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(328, 244);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 8;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(205, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "CALCULADORA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNResultado);
            this.Controls.Add(this.BTNBorrar);
            this.Controls.Add(this.TXBResultado);
            this.Controls.Add(this.IGUAL);
            this.Controls.Add(this.CBOperacion);
            this.Controls.Add(this.TXBB);
            this.Controls.Add(this.TXBA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Punto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXBA;
        private System.Windows.Forms.TextBox TXBB;
        private System.Windows.Forms.ComboBox CBOperacion;
        private System.Windows.Forms.Label IGUAL;
        private System.Windows.Forms.TextBox TXBResultado;
        private System.Windows.Forms.Button BTNBorrar;
        private System.Windows.Forms.Button BTNResultado;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

