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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAgenda));
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblCantidadCon = new System.Windows.Forms.Label();
            this.mtbCantContactos = new System.Windows.Forms.MaskedTextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.gboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(9, 22);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 0;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(9, 68);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(132, 68);
            this.mtbNumero.Mask = "(351)000-0000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(84, 20);
            this.mtbNumero.TabIndex = 2;
            this.mtbNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumero_MaskInputRejected);
            this.mtbNumero.TextChanged += new System.EventHandler(this.mtbNumero_TextChanged);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(132, 22);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(84, 20);
            this.txtContacto.TabIndex = 1;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtContacto_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(136, 120);
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
            this.lstResultado.Location = new System.Drawing.Point(51, 228);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(236, 56);
            this.lstResultado.TabIndex = 5;
            // 
            // lblCantidadCon
            // 
            this.lblCantidadCon.AutoSize = true;
            this.lblCantidadCon.Location = new System.Drawing.Point(27, 311);
            this.lblCantidadCon.Name = "lblCantidadCon";
            this.lblCantidadCon.Size = new System.Drawing.Size(77, 13);
            this.lblCantidadCon.TabIndex = 7;
            this.lblCantidadCon.Text = "CantContactos";
            // 
            // mtbCantContactos
            // 
            this.mtbCantContactos.Location = new System.Drawing.Point(118, 308);
            this.mtbCantContactos.Name = "mtbCantContactos";
            this.mtbCantContactos.Size = new System.Drawing.Size(63, 20);
            this.mtbCantContactos.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(206, 337);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(81, 28);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.btnRegistrar);
            this.gboDatos.Controls.Add(this.btnCancelar);
            this.gboDatos.Controls.Add(this.txtContacto);
            this.gboDatos.Controls.Add(this.mtbNumero);
            this.gboDatos.Controls.Add(this.lblNumero);
            this.gboDatos.Controls.Add(this.lblContacto);
            this.gboDatos.Location = new System.Drawing.Point(51, 41);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(247, 170);
            this.gboDatos.TabIndex = 13;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos";
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(51, 399);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(235, 82);
            this.lstListado.TabIndex = 14;
            // 
            // frmGestionAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 528);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.gboDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.mtbCantContactos);
            this.Controls.Add(this.lblCantidadCon);
            this.Controls.Add(this.lstResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.frmGestionAgenda_Load);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mtbCantContactos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.ListBox lstListado;
    }
}

