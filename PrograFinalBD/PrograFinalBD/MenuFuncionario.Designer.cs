namespace PrograFinalBD
{
    partial class MenuFuncionario
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
            this.BtnAtrasVtnaMenuFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // BtnAtrasVtnaMenuFuncionarios
            // 
            this.BtnAtrasVtnaMenuFuncionarios.BackColor = System.Drawing.Color.DarkRed;
            this.BtnAtrasVtnaMenuFuncionarios.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtrasVtnaMenuFuncionarios.Location = new System.Drawing.Point(463, 303);
            this.BtnAtrasVtnaMenuFuncionarios.Name = "BtnAtrasVtnaMenuFuncionarios";
            this.BtnAtrasVtnaMenuFuncionarios.Size = new System.Drawing.Size(111, 58);
            this.BtnAtrasVtnaMenuFuncionarios.TabIndex = 1;
            this.BtnAtrasVtnaMenuFuncionarios.Text = "ATRAS";
            this.BtnAtrasVtnaMenuFuncionarios.UseVisualStyleBackColor = false;
            this.BtnAtrasVtnaMenuFuncionarios.Click += new System.EventHandler(this.BtnAtrasVtnaMenuFuncionarios_Click);
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources._9290217_M_dico_de_dibujos_animados_que_asisten_a_un_joven_paciente_en_una_sala_de_hospital__Foto_de_archivo1;
            this.ClientSize = new System.Drawing.Size(586, 373);
            this.Controls.Add(this.BtnAtrasVtnaMenuFuncionarios);
            this.Controls.Add(this.label1);
            this.Name = "MenuFuncionario";
            this.Text = "MenuFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAtrasVtnaMenuFuncionarios;
    }
}