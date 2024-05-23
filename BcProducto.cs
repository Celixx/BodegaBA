using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuenosAires.DataLayer;
using BuenosAires.Model;
using BuenosAires.Model.Utiles;

namespace BuenosAires.BusinessLayer
{
    public class BcProducto
    {
        public string Accion = "";
        public string Mensaje = "";
        public bool HayErrores = false;
        public Producto Producto = null;
        public List<Producto> Lista = null;

        public BcProducto()
        {
            Inicializar("");
        }

        public void Inicializar(string accion)
        {
            this.Accion = accion;
            this.Mensaje = "";
            this.HayErrores = false;
            this.Producto = null;
            this.Lista = null;
        }

        private bool ErrCampoRequerido(string nombreCampo)
        {
            this.Mensaje = $"{nombreCampo} es un campo requerido, por lo que debe tener un valor.";
            return false;
        }
        private bool ErrPrecio()
        {
            this.Mensaje = $"El campo precio debe ser un entero mayor que cero.";
            return false;
        }

        private bool ErrID()
        {
            this.Mensaje = $"Cuando el producto es nuevo, el campo ID debe valer cero.";
            return false;
        }

        public bool RetornarMensaje(string mensaje)
        {
            this.Mensaje = mensaje;
            return false;
        }

        public bool ValidarProducto(Producto producto)
        {
            if (producto.idprod < 0) return ErrID();
            if (producto.nomprod.Trim() == "") return ErrCampoRequerido("Nombre de producto");
            if (producto.descprod.Trim() == "") return ErrCampoRequerido($"Descripción de producto");
            if (producto.precio <= 0) return ErrPrecio();
            if (producto.imagen.Trim() == "") return ErrCampoRequerido("Imagen");
            return true;
        }

        public void Crear(Producto producto)
        {
            if (ValidarProducto(producto) == false) return;
            var dc = new DcProducto();
            dc.Crear(producto);
            Util.CopiarPropiedades(dc, this);
        }
        public void LeerTodos()
        {
            var dc = new DcProducto();
            dc.LeerTodos();
            Util.CopiarPropiedades(dc, this);
        }

        public void Leer(int id)
        {
            var dc = new DcProducto();
            dc.Leer(id);
            Util.CopiarPropiedades(dc, this);
        }

        public void Actualizar(Producto producto)
        {
            if (ValidarProducto(producto) == false) return;
            var dc = new DcProducto();
            dc.Actualizar(producto);
            Util.CopiarPropiedades(dc, this);
        }

        public void Eliminar(int id)
        {
            this.Inicializar($"eliminar el producto con el ID {id}");

            // Lo siguiente viene comentado, pues no se puede hacer hasta tener las otras componentes de datos

            // Más adelante verificaremos que el producto que se desea eliminar no tenga movimientos en bodega
            // Más adelante verificaremos que el producto que se desea eliminar no tenga guías de despacho asociadas
            // Más adelante verificaremos que el producto que se desea eliminar no haya sido vendido en facturas ya emitidas
            // Más adelante verificaremos que el producto que se desea eliminar no tenga solicitudes de servicios de técnicos que hayan instalado ese producto

            //var dcstock = new DcStockProducto();
            //int cantidad = dcstock.ContarStockProductoPorProducto(id);
            //if (dcstock.HayErrores) return RetornarMensaje(dcstock.Mensaje);
            //if (cantidad > 0) return RetornarMensaje($"No fue posible {this.Accion} pues tiene {cantidad} productos asociados en la bodega.");

            //var dcguia = new DcGuiaDespacho();
            //cantidad = dcguia.ContarGuiasDespachoPorProducto(id);
            //if (dcguia.HayErrores) return RetornarMensaje(dcguia.Mensaje);
            //if (cantidad > 0) return RetornarMensaje($"No fue posible {this.Accion} pues tiene {cantidad} guia(s) de despacho asociadas.");

            //var dcfac = new DcFactura();
            //dcfac.LeerFacturasPorProducto(id);
            //if (dcfac.HayErrores) return RetornarMensaje(dcfac.Mensaje);
            //int cantsol = 0;
            //var dcsol = new DcSolicitudServicio();
            //foreach (var factura in dcfac.Lista)
            //{
            //    cantsol += dcsol.ContarSolicitudServiciosPorFactura(factura.nrofac);
            //    if (dcsol.HayErrores) return RetornarMensaje(dcsol.Mensaje);
            //}
            //if (cantsol > 0) return RetornarMensaje($"No fue posible {this.Accion} pues tiene {cantsol} solicitud(es) de servico asociadas.");

            //cantidad = dcfac.ContarFacturasPorProducto(id);
            //if (dcfac.HayErrores) return RetornarMensaje(dcfac.Mensaje);
            //if (cantidad > 0) return RetornarMensaje($"No fue posible {this.Accion} pues tiene {cantidad} factura(s) asociadas.");

            var dcprod = new DcProducto();
            dcprod.Eliminar(id);
            Util.CopiarPropiedades(dcprod, this);
        }
    }
}
