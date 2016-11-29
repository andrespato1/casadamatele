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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancelarCita = new System.Windows.Forms.Button();
            this.TextIdCancelar = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 237);
            this.dataGridView1.TabIndex = 0;
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
            this.BtnCancelarCita.Text = "Eliminar";
            this.BtnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // TextIdCancelar
            // 
            this.TextIdCancelar.Location = new System.Drawing.Point(468, 323);
            this.TextIdCancelar.Name = "TextIdCancelar";
            this.TextIdCancelar.Size = new System.Drawing.Size(124, 20);
            this.TextIdCancelar.TabIndex = 2;
            this.TextIdCancelar.Text = "Ingresar Id Cita";
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
            this.Controls.Add(this.TextIdCancelar);
            this.Controls.Add(this.BtnCancelarCita);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CancelarCitas";
            this.Text = "CancelarCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCancelarCita;
        private System.Windows.Forms.TextBox TextIdCancelar;
        private System.Windows.Forms.Button BtnAtras;
    }
}