namespace BuenosAires.BodegaBA
{
    partial class VentanaReservarAnwo
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.nroserieanwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprodanwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioanwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservar Equipos de ANWO";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroserieanwo,
            this.nomprodanwo,
            this.precioanwo,
            this.reservado,
            this.opciones});
            this.grid.Location = new System.Drawing.Point(12, 101);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(776, 309);
            this.grid.TabIndex = 1;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(299, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(162, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver al menú principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // nroserieanwo
            // 
            this.nroserieanwo.DataPropertyName = "nroserieanwo";
            this.nroserieanwo.HeaderText = "Nro Serie";
            this.nroserieanwo.Name = "nroserieanwo";
            // 
            // nomprodanwo
            // 
            this.nomprodanwo.DataPropertyName = "nomprodanwo";
            this.nomprodanwo.HeaderText = "Nombre Producto";
            this.nomprodanwo.Name = "nomprodanwo";
            // 
            // precioanwo
            // 
            this.precioanwo.DataPropertyName = "precioanwo";
            this.precioanwo.HeaderText = "Precio";
            this.precioanwo.Name = "precioanwo";
            // 
            // reservado
            // 
            this.reservado.DataPropertyName = "reservado";
            this.reservado.HeaderText = "Reservado";
            this.reservado.Name = "reservado";
            // 
            // opciones
            // 
            this.opciones.DataPropertyName = "btwReservar";
            this.opciones.HeaderText = "Opciones";
            this.opciones.Name = "opciones";
            this.opciones.Text = "Reservar";
            this.opciones.ToolTipText = "Reservar";
            this.opciones.UseColumnTextForButtonValue = true;
            // 
            // VentanaReservarAnwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label1);
            this.Name = "VentanaReservarAnwo";
            this.Text = "VentanaReservarAnwo";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroserieanwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprodanwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioanwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservado;
        private System.Windows.Forms.DataGridViewButtonColumn opciones;
    }
}