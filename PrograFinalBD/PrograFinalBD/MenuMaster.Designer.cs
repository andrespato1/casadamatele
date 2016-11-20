namespace PrograFinalBD
{
    partial class MenuMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrearCentrosMenuMaster = new System.Windows.Forms.Button();
            this.BtnRegistrarFuncionariosMenuMaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // BtnCrearCentrosMenuMaster
            // 
            this.BtnCrearCentrosMenuMaster.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrearCentrosMenuMaster.Location = new System.Drawing.Point(24, 11);
            this.BtnCrearCentrosMenuMaster.Name = "BtnCrearCentrosMenuMaster";
            this.BtnCrearCentrosMenuMaster.Size = new System.Drawing.Size(245, 23);
            this.BtnCrearCentrosMenuMaster.TabIndex = 1;
            this.BtnCrearCentrosMenuMaster.Text = "Crear Centros de Salud";
            this.BtnCrearCentrosMenuMaster.UseVisualStyleBackColor = false;
            this.BtnCrearCentrosMenuMaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRegistrarFuncionariosMenuMaster
            // 
            this.BtnRegistrarFuncionariosMenuMaster.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegistrarFuncionariosMenuMaster.Location = new System.Drawing.Point(24, 50);
            this.BtnRegistrarFuncionariosMenuMaster.Name = "BtnRegistrarFuncionariosMenuMaster";
            this.BtnRegistrarFuncionariosMenuMaster.Size = new System.Drawing.Size(245, 23);
            this.BtnRegistrarFuncionariosMenuMaster.TabIndex = 2;
            this.BtnRegistrarFuncionariosMenuMaster.Text = "Registrar Funcionarios ";
            this.BtnRegistrarFuncionariosMenuMaster.UseVisualStyleBackColor = false;
            this.BtnRegistrarFuncionariosMenuMaster.Click += new System.EventHandler(this.BtnRegistrarFuncionariosMenuMaster_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "ATRAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenuMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources.depositphotos_7229389_stock_illustration_computer_repair_service;
            this.ClientSize = new System.Drawing.Size(573, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRegistrarFuncionariosMenuMaster);
            this.Controls.Add(this.BtnCrearCentrosMenuMaster);
            this.Controls.Add(this.label1);
            this.Name = "MenuMaster";
            this.Text = "MenuMaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCrearCentrosMenuMaster;
        private System.Windows.Forms.Button BtnRegistrarFuncionariosMenuMaster;
        private System.Windows.Forms.Button button1;
    }
}