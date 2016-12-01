namespace PrograFinalBD
{
    partial class DirectorioDatos
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
            this.Tablas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Button();
            this.Dtabla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablas
            // 
            this.Tablas.AllowUserToOrderColumns = true;
            this.Tablas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tablas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablas.Location = new System.Drawing.Point(186, 91);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(564, 252);
            this.Tablas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre de la tabla a consultar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GT
            // 
            this.GT.Location = new System.Drawing.Point(13, 13);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(112, 23);
            this.GT.TabIndex = 2;
            this.GT.Text = "Generar Tablas";
            this.GT.UseVisualStyleBackColor = true;
            this.GT.Click += new System.EventHandler(this.GT_Click);
            // 
            // Dtabla
            // 
            this.Dtabla.Location = new System.Drawing.Point(453, 16);
            this.Dtabla.Name = "Dtabla";
            this.Dtabla.Size = new System.Drawing.Size(150, 20);
            this.Dtabla.TabIndex = 3;
            this.Dtabla.TextChanged += new System.EventHandler(this.Dtabla_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Realizar otra consulta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 56);
            this.button3.TabIndex = 6;
            this.button3.Text = "Atras";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DirectorioDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrograFinalBD.Properties.Resources.Ideass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 373);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dtabla);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tablas);
            this.Name = "DirectorioDatos";
            this.Text = "DirectorioDatos";
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tablas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GT;
        private System.Windows.Forms.TextBox Dtabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}