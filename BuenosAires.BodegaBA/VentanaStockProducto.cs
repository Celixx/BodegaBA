using BuenosAires.Model.Utiles;
using BuenosAires.ServiceProxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaStockProducto : Form
    {
        public VentanaStockProducto()
        {
            InitializeComponent();
            btnRefrescar.Click += (sender, e) => CargarProducto();
            dgvStock.ConfigurarDataGridView("idprod:ID, nomprod:Nombre, " +
                "descprod:Descripción, precio:Precio, imagen:Imagen, cantidad:Cantidad, " +
                "disponibilidad:Disponibilidad");
            CargarProducto();
            this.CentrarVentana();

        }
        private void VentanaStockProducto_Load(object sender, EventArgs e)
        {  
        }
        private void CargarProducto()
        {
            var bc = new ScStockProducto();
            bc.ObtenerStockProducto();
            dgvStock.DataSource = bc.Lista;
            dgvStock.RefrescarYajustar();
            if (bc.HayErrores == true) this.MensajeInfo(bc.Mensaje);
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new VentanaPrincipal().Show();
            this.Hide();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvStock.Refresh();
        }
    }

}
