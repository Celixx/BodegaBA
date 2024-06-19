namespace BuenosAires.BodegaBA
{
    partial class VentanaPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMantenedor = new System.Windows.Forms.Button();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buenos Aires";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Bodega - Menú Principal";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(175, 296);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(438, 48);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "Reservar Equipos de ANWO";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(175, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(438, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedor.Location = new System.Drawing.Point(175, 205);
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(438, 38);
            this.btnMantenedor.TabIndex = 5;
            this.btnMantenedor.Text = "Mantenedor de Productos";
            this.btnMantenedor.UseVisualStyleBackColor = true;
            this.btnMantenedor.Click += new System.EventHandler(this.btnMantenedor_Click);
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.Location = new System.Drawing.Point(175, 249);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(438, 41);
            this.btnAdministrar.TabIndex = 6;
            this.btnAdministrar.Text = "Administrar Guías";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnConsultarStock
            // 
            this.btnConsultarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarStock.Location = new System.Drawing.Point(175, 350);
            this.btnConsultarStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Size = new System.Drawing.Size(438, 44);
            this.btnConsultarStock.TabIndex = 7;
            this.btnConsultarStock.Text = "Consultar Stock en Bodega";
            this.btnConsultarStock.UseVisualStyleBackColor = true;
            this.btnConsultarStock.Click += new System.EventHandler(this.btnConsultarStock_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnConsultarStock);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.btnMantenedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipal";
            this.Text = "Sistema BodegaBA";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMantenedor;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnConsultarStock;
    }
}