
namespace ChipDeck
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.label3 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.Label();
            this.puesto = new System.Windows.Forms.Label();
            this.datoCorredor = new System.Windows.Forms.Panel();
            this.nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cerrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.datoCorredor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inforamacion del Corredor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiempo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(23, 96);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(88, 26);
            this.tiempo.TabIndex = 4;
            this.tiempo.Text = "Tiempo: ";
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoria.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(24, 44);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(105, 26);
            this.categoria.TabIndex = 5;
            this.categoria.Text = "Categoria: ";
            // 
            // puesto
            // 
            this.puesto.AutoSize = true;
            this.puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puesto.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puesto.Location = new System.Drawing.Point(23, 70);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(82, 26);
            this.puesto.TabIndex = 6;
            this.puesto.Text = "Puesto: ";
            // 
            // datoCorredor
            // 
            this.datoCorredor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datoCorredor.BackColor = System.Drawing.Color.Red;
            this.datoCorredor.Controls.Add(this.nombre);
            this.datoCorredor.Controls.Add(this.label5);
            this.datoCorredor.Controls.Add(this.tiempo);
            this.datoCorredor.Controls.Add(this.puesto);
            this.datoCorredor.Controls.Add(this.categoria);
            this.datoCorredor.Location = new System.Drawing.Point(105, 116);
            this.datoCorredor.Name = "datoCorredor";
            this.datoCorredor.Size = new System.Drawing.Size(369, 147);
            this.datoCorredor.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(24, 18);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(94, 26);
            this.nombre.TabIndex = 8;
            this.nombre.Text = "Nombre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 7;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cerrar.AutoSize = true;
            this.cerrar.BackColor = System.Drawing.Color.Gray;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(372, 310);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(140, 35);
            this.cerrar.TabIndex = 9;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ChipTimer.Properties.Resources._0d671963710fdb605fda69b32b70c51a;
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.imprimir);
            this.panel1.Controls.Add(this.cerrar);
            this.panel1.Controls.Add(this.datoCorredor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(241, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 380);
            this.panel1.TabIndex = 10;
            // 
            // imprimir
            // 
            this.imprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imprimir.AutoSize = true;
            this.imprimir.BackColor = System.Drawing.Color.Gray;
            this.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imprimir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Location = new System.Drawing.Point(40, 310);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(140, 35);
            this.imprimir.TabIndex = 10;
            this.imprimir.Text = "Imprimir";
            this.imprimir.UseVisualStyleBackColor = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChipTimer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Info_Load);
            this.datoCorredor.ResumeLayout(false);
            this.datoCorredor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label puesto;
        private System.Windows.Forms.Panel datoCorredor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}