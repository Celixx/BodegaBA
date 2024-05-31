using BuenosAires.Model.Utiles;
using BuenosAires.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsGuiaDespacho" in code, svc and config file together.
public class WsGuiaDespacho : IWsGuiaDespacho
{
    public Respuesta obtener_guias_de_despacho()
    {
        var resp = new Respuesta();
        resp.Accion = "autenticar al usuario";
        resp.Mensaje = "";
        resp.HayErrores = false;
        resp.XmlListaGuiaDespacho = "";

        string apiUrl = "http://127.0.0.1:8000/BuenosAiresApiRest/obtener_guias_de_despacho/";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    List<ListaGuiaDespacho> lista = JsonConvert.DeserializeObject<List<ListaGuiaDespacho>>(json);
                    resp.XmlListaGuiaDespacho = Util.SerializarXML(lista);
                }
                else
                {
                    resp.HayErrores = true;
                    resp.Mensaje = "No fue posible obtener las guias de despacho, intente nuevamente más tarde "
                        + "o comuníquese con el Administrador del Sistema";
                }
                return resp;
            }
        }
        catch (Exception ex)
        {
            resp.HayErrores = true;
            resp.Mensaje = Util.MensajeError(resp.Accion, "WsGuiaDespacho.obtener_guias_de_despacho", ex);
            return resp;
        }
    }

    public void actualizar_estado_guia_despacho(int nrogd, string estadogd)
    {
        string apiUrl = "http://127.0.0.1:8000/BuenosAiresApiRest/actualizar_estado_guia_despacho/"+nrogd+"/"+estadogd;
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            return;
        }
    }
}


