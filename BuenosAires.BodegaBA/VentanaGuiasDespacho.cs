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
            var listaxd = getData();
            foreach ( var item in listaxd )
            {
                if ( item != null )
                {
                    string[] row =
                    {
                        item.nrogd.ToString(), item.descfac, item.estadogd, item.nrofac.ToString(), item.nomcli
                    };
                    grid.Rows.Add( row );
                }
            }
            //grid.DataSource.

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
            grid.Refresh();
        }

    }
}
