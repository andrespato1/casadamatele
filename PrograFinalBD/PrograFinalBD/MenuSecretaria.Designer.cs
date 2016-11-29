namespace PrograFinalBD
{
    partial class MenuSecretaria
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
            this.BtnCancelarCita = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCancelarCita
            // 
            this.BtnCancelarCita.BackColor = System.Drawing.Color.Indigo;
            this.BtnCancelarCita.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCita.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCancelarCita.Location = new System.Drawing.Point(12, 12);
            this.BtnCancelarCita.Name = "BtnCancelarCita";
            this.BtnCancelarCita.Size = new System.Drawing.Size(91, 54);
            this.BtnCancelarCita.TabIndex = 0;
            this.BtnCancelarCita.Text = "Cancelar Cita";
            this.BtnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.BackColor = System.Drawing.Color.Blue;
            this.BtnAyuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAyuda.Location = new System.Drawing.Point(12, 332);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(108, 38);
            this.BtnAyuda.TabIndex = 1;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.UseVisualStyleBackColor = false;
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Red;
            this.BtnAtras.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.Black;
            this.BtnAtras.Location = new System.Drawing.Point(473, 311);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(108, 59);
            this.BtnAtras.TabIndex = 2;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // MenuSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources._9290217_M_dico_de_dibujos_animados_que_asisten_a_un_joven_paciente_en_una_sala_de_hospital__Foto_de_archivo1;
            this.ClientSize = new System.Drawing.Size(584, 382);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.BtnCancelarCita);
            this.Name = "MenuSecretaria";
            this.Text = "MenuSecretaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelarCita;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Button BtnAtras;
    }
}