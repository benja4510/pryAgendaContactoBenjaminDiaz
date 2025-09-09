namespace pryAgendaContactoBenjaminDiaz
{
    partial class frmGestionAgenda
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
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblCantidadCon = new System.Windows.Forms.Label();
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.mtbCantContactos = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbFechayhora = new System.Windows.Forms.MaskedTextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(48, 23);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 0;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(48, 69);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(171, 69);
            this.mtbNumero.Mask = "(351)000-0000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(84, 20);
            this.mtbNumero.TabIndex = 2;
            this.mtbNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumero_MaskInputRejected);
            this.mtbNumero.TextChanged += new System.EventHandler(this.mtbNumero_TextChanged);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(171, 23);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(84, 20);
            this.txtContacto.TabIndex = 1;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtContacto_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(51, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(175, 121);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 36);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(51, 194);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(236, 56);
            this.lstResultado.TabIndex = 5;
            // 
            // lblCantidadCon
            // 
            this.lblCantidadCon.AutoSize = true;
            this.lblCantidadCon.Location = new System.Drawing.Point(35, 279);
            this.lblCantidadCon.Name = "lblCantidadCon";
            this.lblCantidadCon.Size = new System.Drawing.Size(77, 13);
            this.lblCantidadCon.TabIndex = 7;
            this.lblCantidadCon.Text = "CantContactos";
            // 
            // lblFechayHora
            // 
            this.lblFechayHora.AutoSize = true;
            this.lblFechayHora.Location = new System.Drawing.Point(293, 251);
            this.lblFechayHora.Name = "lblFechayHora";
            this.lblFechayHora.Size = new System.Drawing.Size(71, 13);
            this.lblFechayHora.TabIndex = 8;
            this.lblFechayHora.Text = "Fecha y Hora";
            // 
            // mtbCantContactos
            // 
            this.mtbCantContactos.Location = new System.Drawing.Point(118, 275);
            this.mtbCantContactos.Name = "mtbCantContactos";
            this.mtbCantContactos.Size = new System.Drawing.Size(63, 20);
            this.mtbCantContactos.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // mtbFechayhora
            // 
            this.mtbFechayhora.Location = new System.Drawing.Point(216, 244);
            this.mtbFechayhora.Mask = "00/00/0000 00:00";
            this.mtbFechayhora.Name = "mtbFechayhora";
            this.mtbFechayhora.Size = new System.Drawing.Size(71, 20);
            this.mtbFechayhora.TabIndex = 9;
            this.mtbFechayhora.ValidatingType = typeof(System.DateTime);
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Location = new System.Drawing.Point(65, 349);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(81, 28);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmGestionAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 425);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbCantContactos);
            this.Controls.Add(this.mtbFechayhora);
            this.Controls.Add(this.lblFechayHora);
            this.Controls.Add(this.lblCantidadCon);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblContacto);
            this.Name = "frmGestionAgenda";
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.frmGestionAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label lblCantidadCon;
        private System.Windows.Forms.Label lblFechayHora;
        private System.Windows.Forms.MaskedTextBox mtbCantContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbFechayhora;
        private System.Windows.Forms.Button btnListar;
    }
}

