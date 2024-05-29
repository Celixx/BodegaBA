using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.Model.Utiles;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaGuiasDespacho : Form
    {
        public VentanaGuiasDespacho()
        {
            InitializeComponent();
            grid.ConfigurarDataGridView("nrogd:Nro GD, nomprod:Producto, "
                + "fechafac:Fecha GD, estadogd:Estado GD, nrofac: Nro Factura, nombre:Cliente");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new VentanaPrincipal();
            Hide(); 
        }

        public void CargarGuiasDespacho()
        {
            var bc = new ScGuiaDespacho();
        }
    }
}
