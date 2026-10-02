namespace CajeroATM
{
    partial class frmLogin
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblIntento = new System.Windows.Forms.Label();
            this.picBanco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(87, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "cajero automatico";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(90, 40);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(114, 16);
            this.lblTarjeta.TabIndex = 1;
            this.lblTarjeta.Text = "numero de tarjeta:";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(93, 68);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 22);
            this.txtTarjeta.TabIndex = 2;
            this.txtTarjeta.Text = "(vacio)";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(106, 104);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(71, 16);
            this.lblPin.TabIndex = 3;
            this.lblPin.Text = "PIN/Clave:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(90, 135);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 22);
            this.txtPin.TabIndex = 4;
            this.txtPin.Text = "PasswordChar=*";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(102, 180);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(102, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblIntento
            // 
            this.lblIntento.AutoSize = true;
            this.lblIntento.Location = new System.Drawing.Point(90, 326);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(0, 16);
            this.lblIntento.TabIndex = 7;
            // 
            // picBanco
            // 
            this.picBanco.Image = global::cajero_automatico.Properties.Resources.Captura_de_pantalla_2_7_2026_22913_web_whatsapp_com;
            this.picBanco.Location = new System.Drawing.Point(102, 275);
            this.picBanco.Name = "picBanco";
            this.picBanco.Size = new System.Drawing.Size(68, 115);
            this.picBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanco.TabIndex = 8;
            this.picBanco.TabStop = false;
            this.picBanco.Click += new System.EventHandler(this.picBanco_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 400);
            this.Controls.Add(this.picBanco);
            this.Controls.Add(this.lblIntento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox picBanco;
        public System.Windows.Forms.TextBox txtTarjeta;
        public System.Windows.Forms.Label lblPin;
        public System.Windows.Forms.TextBox txtPin;
        public System.Windows.Forms.Label lblIntento;
    }
}

