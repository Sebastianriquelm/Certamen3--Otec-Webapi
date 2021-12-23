using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationOtec.Models;
using OtecLibrary;

namespace WebApplicationOtec.Controllers
{
    public class AsigController : ApiController
    {
        [HttpGet]
        [Route("API/CertamenN3/Asignatura")]
        public Alerta_asignatura ListarAPI(string cod_asignatura = "")
        {
            Alerta_asignatura respuesta = new Alerta_asignatura();
            try
            {
                List<Asignatura> listadoapi = new List<Asignatura>();
                 ASIGNATURA  asignaturadatos= new ASIGNATURA();
                DataSet Datos = cod_asignatura == "" ? asignaturadatos.listadocordinador() : asignaturadatos.listadocordinador(cod_asignatura);

                for (int i = 0; i < Datos.Tables[0].Rows.Count; i++)
                {
                    Asignatura item = new Asignatura();
                    item.cod_asignatunra = Datos.Tables[0].Rows[i].ItemArray[0].ToString();
                    item.nom_asignatura = Datos.Tables[0].Rows[i].ItemArray[1].ToString();
                    listadoapi.Add(item);
                }
                respuesta.error = false;
                respuesta.mensaje = "Aceptado";
                if (listadoapi.Count > 0)
                    respuesta.data = listadoapi;
                else
                    respuesta.data = "No se Encontro Asignatura";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.error = true;
                respuesta.mensaje = "Error:" + e.Message;
                respuesta.data = null;
                return respuesta;
            }

        }

        [HttpPost]
        [Route("API/CertamenN3/Asignatura")]
        public Alerta_asignatura guardarasi(ASIGNATURA asignatura )
        {
            Alerta_asignatura respuesta = new Alerta_asignatura();
            try
            {
                ASIGNATURA asi = new ASIGNATURA(asignatura.Cod_asignatura, asignatura.Nom_asignatura);
                int x = asi.guardarasi();

                if (x == 1)
                {
                    respuesta.error = false;
                    respuesta.mensaje = "Cliente Ingresado Correctamente";
                }
                else
                {
                    respuesta.error = true;
                    respuesta.mensaje = "ERROR: Error en el Ingreso";
                    respuesta.data = null;
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.error = true;
                respuesta.mensaje = "Error:" + e.Message;
                respuesta.data = null;
                return respuesta;
            }
        }
        [HttpDelete]
        [Route("API/CertamenN3/Asignatura")]
        public Alerta_asignatura eliminarasi(string asignatura)
        {
            Alerta_asignatura respuesta = new Alerta_asignatura();
            try
            {

                ASIGNATURA asig = new ASIGNATURA();
                asig.Cod_asignatura = asignatura;
                int z = asig.eliminarasi();

                if (z == 1)
                {
                    respuesta.error = false;
                    respuesta.mensaje = "Asignatura eliminada Correctamente";
                    respuesta.data = null;
                }
                else
                {
                    respuesta.error = true;
                    respuesta.mensaje = "Eliminacion Fallida";
                    respuesta.data = null;
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.error = true;
                respuesta.mensaje = "Error:" + e.Message;
                respuesta.data = null;
                return respuesta;
            }
        }
        [HttpPut]
        [Route("API/CertamenN3/Asignatura")]
        public Alerta_asignatura actualizarasi(ASIGNATURA asignatura)
        {
            Alerta_asignatura respuesta = new Alerta_asignatura();
            try
            {
                ASIGNATURA asig = new ASIGNATURA(asignatura.Cod_asignatura, asignatura.Nom_asignatura);
                int x = asig.modificarasi(asig);

                if (x == 1)
                {
                    respuesta.error = false;
                    respuesta.mensaje = "Asignatura modificada";
                    respuesta.data = asignatura;
                }
                else
                {
                    respuesta.error = true;
                    respuesta.mensaje = "No se realizó la modificiación";
                    respuesta.data = null;
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.error = true;
                respuesta.mensaje = "Error:" + e.Message;
                respuesta.data = null;
                return respuesta;
            }
        }
    }
}