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

        public bool RetornarError(string mensaje)
        {
            this.HayErrores = true;
            this.Mensaje = mensaje;
            return false;
        }

        public bool RetornarMensaje(string mensaje)
        {
            this.Mensaje = mensaje;
            return false;
        }

        public bool ValidarProducto(Producto producto)
        {
            this.HayErrores = true;
            if (producto.idprod < 0) return ErrID();
            if (producto.nomprod.Trim() == "") return ErrCampoRequerido("Nombre de producto");
            if (producto.descprod.Trim() == "") return ErrCampoRequerido($"Descripción de producto");
            if (producto.precio <= 0) return ErrPrecio();
            if (producto.imagen.Trim() == "") return ErrCampoRequerido("Imagen");
            this.HayErrores = false;
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

        public bool Eliminar(int id)
        {
            this.Inicializar($"eliminar el producto con el ID {id}");
            int cantidad = 0;

            var dcstock = new DcStockProducto();
            cantidad = dcstock.ContarStockProductoPorProducto(id);
            if (dcstock.HayErrores) return RetornarError(dcstock.Mensaje);
            if (cantidad > 0) return RetornarError($"No fue posible {this.Accion} pues tiene {cantidad} productos asociados en la bodega.");

            var dcguia = new DcGuiaDespacho();
            cantidad = dcguia.ContarGuiasDespachoPorProducto(id);
            if (dcguia.HayErrores) return RetornarError(dcguia.Mensaje);
            if (cantidad > 0) return RetornarError($"No fue posible {this.Accion} pues tiene {cantidad} guia(s) de despacho asociadas.");

            var dcfac = new DcFactura();
            dcfac.LeerFacturasPorProducto(id);
            if (dcfac.HayErrores) return RetornarError(dcfac.Mensaje);
            int cantsol = 0;
            var dcsol = new DcSolicitudServicio();
            foreach (var factura in dcfac.Lista)
            {
                cantsol += dcsol.ContarSolicitudServiciosPorFactura(factura.nrofac);
                if (dcsol.HayErrores) return RetornarError(dcsol.Mensaje);
            }
            if (cantsol > 0) return RetornarError($"No fue posible {this.Accion} pues tiene {cantsol} solicitud(es) de servico asociadas.");

            cantidad = dcfac.ContarFacturasPorProducto(id);
            if (dcfac.HayErrores) return RetornarError(dcfac.Mensaje);
            if (cantidad > 0) return RetornarError($"No fue posible {this.Accion} pues tiene {cantidad} factura(s) asociadas.");

            var dcprod = new DcProducto();
            dcprod.Eliminar(id);
            if (dcprod.HayErrores) return RetornarError(dcprod.Mensaje);

            Util.CopiarPropiedades(dcprod, this);
            return true;
        }
    }
}
