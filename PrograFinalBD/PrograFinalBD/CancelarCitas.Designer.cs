namespace PrograFinalBD
{
    partial class CancelarCitas
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
            this.DataGridCancelarCitas = new System.Windows.Forms.DataGridView();
            this.BtnCancelarCita = new System.Windows.Forms.Button();
            this.TxtIdCancelar = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCancelarCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridCancelarCitas
            // 
            this.DataGridCancelarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCancelarCitas.Location = new System.Drawing.Point(12, 12);
            this.DataGridCancelarCitas.Name = "DataGridCancelarCitas";
            this.DataGridCancelarCitas.Size = new System.Drawing.Size(390, 237);
            this.DataGridCancelarCitas.TabIndex = 0;
            // 
            // BtnCancelarCita
            // 
            this.BtnCancelarCita.BackColor = System.Drawing.Color.Black;
            this.BtnCancelarCita.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCita.ForeColor = System.Drawing.Color.White;
            this.BtnCancelarCita.Location = new System.Drawing.Point(468, 263);
            this.BtnCancelarCita.Name = "BtnCancelarCita";
            this.BtnCancelarCita.Size = new System.Drawing.Size(124, 44);
            this.BtnCancelarCita.TabIndex = 1;
            this.BtnCancelarCita.Text = "Cancelar";
            this.BtnCancelarCita.UseVisualStyleBackColor = false;
            this.BtnCancelarCita.Click += new System.EventHandler(this.BtnCancelarCita_Click);
            // 
            // TxtIdCancelar
            // 
            this.TxtIdCancelar.Location = new System.Drawing.Point(468, 323);
            this.TxtIdCancelar.Name = "TxtIdCancelar";
            this.TxtIdCancelar.Size = new System.Drawing.Size(124, 20);
            this.TxtIdCancelar.TabIndex = 2;
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Red;
            this.BtnAtras.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.Black;
            this.BtnAtras.Location = new System.Drawing.Point(468, 12);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(124, 44);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // CancelarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources.cancelling_an_it_project_100413129_primary_idge;
            this.ClientSize = new System.Drawing.Size(604, 374);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.TxtIdCancelar);
            this.Controls.Add(this.BtnCancelarCita);
            this.Controls.Add(this.DataGridCancelarCitas);
            this.Name = "CancelarCitas";
            this.Text = "CancelarCitas";
            this.Load += new System.EventHandler(this.CancelarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCancelarCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCancelarCitas;
        private System.Windows.Forms.Button BtnCancelarCita;
        private System.Windows.Forms.TextBox TxtIdCancelar;
        private System.Windows.Forms.Button BtnAtras;
    }
}