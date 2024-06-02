using BuenosAires.BodegaBA.WsAnwoReference;
using BuenosAires.Model.Utiles;
using BuenosAires.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaReservarAnwo : Form
    {
        private IWsAnwo ws = new WsAnwoClient();
        public VentanaReservarAnwo()
        {
            InitializeComponent();
            poblarTabla();
        }

        private void poblarTabla()
        {
            var listaxd = getData();
            foreach (var item in listaxd)
            {
                if (item != null)
                {
                    string[] row =
                    {
                        item.nroserieanwo, item.nomprodanwo, item.precioanwo.ToString(), item.reservado
                    };
                    grid.Rows.Add(row);
                }
            }
        }

        private List<Anwo> getData()
        {
            var respuesta = ws.consultar_productos_disponibles();
            if (respuesta.HayErrores == true) this.MensajeInfo(respuesta.Mensaje);
            var lista = Util.DeserializarXML<List<Anwo>>(respuesta.XmlListaAnwoStockProducto);
            return new List<Anwo>(lista);

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            new VentanaPrincipal().Show();
            this.Hide();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid.Rows[e.RowIndex];
            if (row.Cells["reservado"].Value.ToString() == "S")
            {
                MessageBox.Show("No se puede reservar un producto ya reservado.");
            }
            else
            {
                string nroserieanwo = row.Cells["nroserieanwo"].Value.ToString();
                ws.reservar_producto(nroserieanwo, "S");
                MessageBox.Show("Producto reservado exitosamente");
                grid.Rows.Clear();
                poblarTabla();
            }
        }
    }
}
