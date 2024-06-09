using BuenosAires.BodegaBA.WsStockProductoReference;
using BuenosAires.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using BuenosAires.Model.Utiles;

namespace BuenosAires.ServiceProxy
{
    public class ScStockProducto
    {
        public class StockProducto
        {
            public int idprod { get; set; }
            public string nomprod { get; set; }
            public string descprod { get; set; }
            public int precio { get; set; }
            public string imagen { get; set; }
            public int cantidad { get; set; }
            public string disponibilidad { get; set; }
        }

        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public string JsonStockProducto = "";
        public List<StockProducto> Lista = new List<StockProducto>();

        public void CopiarPropiedades(Respuesta resp)
        {
            this.Accion = resp.Accion;
            this.Mensaje = resp.Mensaje;
            this.HayErrores = resp.HayErrores;
            this.JsonStockProducto = resp.JsonStockProducto;

            if (resp.JsonStockProducto != "")
            {
                this.Lista =
                     JsonConvert.DeserializeObject<List<StockProducto>>(resp.JsonStockProducto);
                this.Mensaje = resp.Mensaje;
            }

        }
        public WsStockProductoClient getWs()
        {
            var ws = new WsStockProductoClient();
            ws.InnerChannel.OperationTimeout = new TimeSpan(1, 0, 0); //1 hora
            return ws;
        }

        public void ObtenerStockProducto()
        {
            CopiarPropiedades(getWs().obtener_equipos_en_bodega());
        }
    }
}
