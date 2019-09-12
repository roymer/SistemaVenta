namespace SistemaVenta.Presentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cuentaLabel;
            System.Windows.Forms.Label passwordLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuentaTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            cuentaLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(SistemaVenta.Datos.Usuario);
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Location = new System.Drawing.Point(83, 36);
            cuentaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(59, 18);
            cuentaLabel.TabIndex = 1;
            cuentaLabel.Text = "Cuenta:";
            // 
            // cuentaTextBox
            // 
            this.cuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cuenta", true));
            this.cuentaTextBox.Location = new System.Drawing.Point(150, 33);
            this.cuentaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuentaTextBox.Name = "cuentaTextBox";
            this.cuentaTextBox.Size = new System.Drawing.Size(148, 24);
            this.cuentaTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(63, 68);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(79, 18);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(150, 65);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 24);
            this.passwordTextBox.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(198, 116);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 194);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(cuentaLabel);
            this.Controls.Add(this.cuentaTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox cuentaTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnAceptar;
    }
}