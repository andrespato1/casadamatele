namespace PrograFinalBD
{
    partial class PantallaPrincipalDelPrograma
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
            this.TxtUsuarioPantallaPrincipal = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtClavePantallaPrincipal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngresarPantallaPrincipal = new System.Windows.Forms.Button();
            this.CbTiposUsuariosPantallaPrincipal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuarioPantallaPrincipal
            // 
            this.TxtUsuarioPantallaPrincipal.Location = new System.Drawing.Point(294, 120);
            this.TxtUsuarioPantallaPrincipal.Name = "TxtUsuarioPantallaPrincipal";
            this.TxtUsuarioPantallaPrincipal.Size = new System.Drawing.Size(92, 20);
            this.TxtUsuarioPantallaPrincipal.TabIndex = 0;
            // 
            // TxtClavePantallaPrincipal
            // 
            this.TxtClavePantallaPrincipal.Location = new System.Drawing.Point(392, 120);
            this.TxtClavePantallaPrincipal.Name = "TxtClavePantallaPrincipal";
            this.TxtClavePantallaPrincipal.Size = new System.Drawing.Size(99, 20);
            this.TxtClavePantallaPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese codigo de usuario y la contraseña";
            // 
            // BtnIngresarPantallaPrincipal
            // 
            this.BtnIngresarPantallaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresarPantallaPrincipal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarPantallaPrincipal.Location = new System.Drawing.Point(275, 155);
            this.BtnIngresarPantallaPrincipal.Name = "BtnIngresarPantallaPrincipal";
            this.BtnIngresarPantallaPrincipal.Size = new System.Drawing.Size(81, 30);
            this.BtnIngresarPantallaPrincipal.TabIndex = 3;
            this.BtnIngresarPantallaPrincipal.Text = "Ingresar";
            this.BtnIngresarPantallaPrincipal.UseVisualStyleBackColor = false;
            this.BtnIngresarPantallaPrincipal.Click += new System.EventHandler(this.BtnIngresarPantallaPrincipal_Click);
            // 
            // CbTiposUsuariosPantallaPrincipal
            // 
            this.CbTiposUsuariosPantallaPrincipal.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTiposUsuariosPantallaPrincipal.FormattingEnabled = true;
            this.CbTiposUsuariosPantallaPrincipal.Items.AddRange(new object[] {
            "Funcionario",
            "Paciente",
            "Especial"});
            this.CbTiposUsuariosPantallaPrincipal.Location = new System.Drawing.Point(181, 120);
            this.CbTiposUsuariosPantallaPrincipal.Name = "CbTiposUsuariosPantallaPrincipal";
            this.CbTiposUsuariosPantallaPrincipal.Size = new System.Drawing.Size(107, 24);
            this.CbTiposUsuariosPantallaPrincipal.TabIndex = 4;
            // 
            // PantallaPrincipalDelPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources.elementos_graficos_de_medicina_23_2147490516;
            this.ClientSize = new System.Drawing.Size(628, 271);
            this.Controls.Add(this.CbTiposUsuariosPantallaPrincipal);
            this.Controls.Add(this.BtnIngresarPantallaPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClavePantallaPrincipal);
            this.Controls.Add(this.TxtUsuarioPantallaPrincipal);
            this.Name = "PantallaPrincipalDelPrograma";
            this.Text = "PantallaPrincipalDelPrograma";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuarioPantallaPrincipal;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox TxtClavePantallaPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresarPantallaPrincipal;
        private System.Windows.Forms.ComboBox CbTiposUsuariosPantallaPrincipal;
    }
}