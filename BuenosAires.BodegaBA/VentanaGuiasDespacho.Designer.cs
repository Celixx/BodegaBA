namespace BuenosAires.BodegaBA
{
    partial class VentanaGuiasDespacho
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.nrogd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descfac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadogd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcionDespachado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.opcionImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.opcionEntregado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buenos Aires";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guías de Despacho";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(328, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(146, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver al menú principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrogd,
            this.descfac,
            this.estadogd,
            this.nrofac,
            this.nomcli,
            this.opcionDespachado,
            this.opcionImprimir,
            this.opcionEntregado});
            this.grid.Location = new System.Drawing.Point(16, 73);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(844, 336);
            this.grid.TabIndex = 3;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // nrogd
            // 
            this.nrogd.DataPropertyName = "ListaGuiaDespacho.nrogd";
            this.nrogd.HeaderText = "Nro Gd";
            this.nrogd.Name = "nrogd";
            // 
            // descfac
            // 
            this.descfac.DataPropertyName = "descfac";
            this.descfac.HeaderText = "Producto";
            this.descfac.Name = "descfac";
            // 
            // estadogd
            // 
            this.estadogd.DataPropertyName = "estadogd";
            this.estadogd.HeaderText = "Estado GD";
            this.estadogd.Name = "estadogd";
            // 
            // nrofac
            // 
            this.nrofac.DataPropertyName = "nrofac";
            this.nrofac.HeaderText = "Nro Fac";
            this.nrofac.Name = "nrofac";
            // 
            // nomcli
            // 
            this.nomcli.DataPropertyName = "nomcli";
            this.nomcli.HeaderText = "Cliente";
            this.nomcli.Name = "nomcli";
            // 
            // opcionDespachado
            // 
            this.opcionDespachado.HeaderText = "Opción Despachado";
            this.opcionDespachado.Name = "opcionDespachado";
            this.opcionDespachado.Text = "Despachado";
            this.opcionDespachado.UseColumnTextForButtonValue = true;
            // 
            // opcionImprimir
            // 
            this.opcionImprimir.HeaderText = "Opción Imprimir";
            this.opcionImprimir.Name = "opcionImprimir";
            this.opcionImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opcionImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.opcionImprimir.Text = "Imprimir";
            this.opcionImprimir.UseColumnTextForButtonValue = true;
            // 
            // opcionEntregado
            // 
            this.opcionEntregado.HeaderText = "Opción Entregado";
            this.opcionEntregado.Name = "opcionEntregado";
            this.opcionEntregado.Text = "Entregado";
            this.opcionEntregado.UseColumnTextForButtonValue = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(480, 415);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // VentanaGuiasDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaGuiasDespacho";
            this.Text = "VentanaGuiasDespacho";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrogd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descfac;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadogd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcli;
        private System.Windows.Forms.DataGridViewButtonColumn opcionDespachado;
        private System.Windows.Forms.DataGridViewButtonColumn opcionImprimir;
        private System.Windows.Forms.DataGridViewButtonColumn opcionEntregado;
        private System.Windows.Forms.Button btnRefrescar;
    }
}