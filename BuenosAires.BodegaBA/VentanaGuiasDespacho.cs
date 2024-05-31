using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuenosAires.BodegaBA.WsGuiaDespachoReference;
using BuenosAires.Model;
using BuenosAires.Model.Utiles;

namespace BuenosAires.BodegaBA
{
    public partial class VentanaGuiasDespacho : Form
    {

        private WsGuiaDespachoClient ws = new WsGuiaDespachoClient();

        public VentanaGuiasDespacho()
        {
            InitializeComponent();
            //grid.ConfigurarDataGridView("nrogd:Nro GD, nomprod:Producto, "
            //+ "fechafac:Fecha GD, estadogd:Estado GD, nrofac: Nro Factura, nombre:Cliente");
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
                        item.nrogd.ToString(), item.descfac, item.estadogd, item.nrofac.ToString(), item.nomcli
                    };
                    grid.Rows.Add(row);
                }
            }
        }

        private List<ListaGuiaDespacho> getData()
        {
            var respuesta = ws.obtener_guias_de_despacho();
            if (respuesta.HayErrores == true) this.MensajeInfo(respuesta.Mensaje);
            var lista = Util.DeserializarXML<List<ListaGuiaDespacho>>(respuesta.XmlListaGuiaDespacho);
            return new List<ListaGuiaDespacho>(lista);
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new VentanaPrincipal().Show();
            this.Hide();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grid.Rows[e.RowIndex];
            if (e.ColumnIndex == this.grid.Columns["opcionDespachado"].Index)
            {
                if (row.Cells["estadogd"].Value.ToString() == "Despachado" || row.Cells["estadogd"].Value.ToString() == "Depachado")
                {
                    MessageBox.Show("La guía de despacho seleccionada ya se encuentra despachada.");
                }
                else
                {
                    int nrogd = Convert.ToInt32(row.Cells["nrogd"].Value.ToString());
                    string estadogd = "Despachado";
                    ws.actualizar_estado_guia_despacho(nrogd, estadogd);
                    grid.Rows.Clear();
                    poblarTabla();
                }
            }
            else if (e.ColumnIndex == this.grid.Columns["opcionImprimir"].Index) 
            {
                MessageBox.Show("Imprimir");
            }
            else if (e.ColumnIndex == this.grid.Columns["opcionEntregado"].Index)
            {
                if (row.Cells["estadogd"].Value.ToString() == "Entregado")
                {
                    MessageBox.Show("La guía de despacho seleccionada ya se encuentra entregada.");
                }
                else
                {
                    int nrogd = Convert.ToInt32(row.Cells["nrogd"].Value.ToString());
                    string estadogd = "Entregado";
                    ws.actualizar_estado_guia_despacho(nrogd, estadogd);
                    grid.Rows.Clear();
                    poblarTabla();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            grid.Refresh();
        }
    }
}
