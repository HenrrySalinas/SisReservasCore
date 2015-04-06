using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DominioEntidades.SisReservas;
using DominioServicios.SisReservas.Interfaz;
using PersistenciaModelo.SisReservas;

namespace PersistenciaRepositorio.SisReservas.Clases
{
    public class CPersistenciaReportes:IDominioReportes
    {
        
        /// <summary>
        /// LISTAR GENERO
        /// </summary>
        /// <param name="strCredencial"></param>
        /// <param name="oListarFeriado"></param>
        /// <param name="strMensajeError"></param>
        /// <returns></returns>
        public List<O_LISTAR_GENERO> ListarGenero(string strCredencial, O_LISTAR_GENERO oListarGenero, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())//conexion a la ase con using y vatodo el codigo
            {
                try
                {
                    var objListado =
                        ctx.PGET_LISTADOS_P_LISTAR_GENERO(strCredencial,
                                                            oListarGenero.ID_GENERO,
                                                            oListarGenero.DESCRIPCION,
                                                            oListarGenero.APP_ID_USUARIO,
                                                            oListarGenero.AUD_ESTADO,
                                                            oListarGenero.FECHA_REGISTRO
                                                            ).ToList();
                    return objListado;
                }
                catch (Exception ex)
                {
                    strMensajeError = "Error 200: " + ex.Message + "-" + ex.InnerException;
                    return null;
                }
            }
        }
        /// <summary>
        /// Implementacion nucleo de la interfaz de la capa DominioServicios
        /// </summary>
        /// <param name="strCredencial"></param>
        /// <param name="oListarPersona"></param>
        /// <param name="strMensajeError"></param>
        /// <returns></returns>
        public List<O_LISTAR_PERSONA> ListarPersona(string strCredencial, O_LISTAR_PERSONA oListarPersona, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objListado =
                        ctx.PGET_LISTADOS_P_LISTAR_PERSONA(strCredencial,
                                                            oListarPersona.ID_PERSONA,
                                                            oListarPersona.ID_TIPO_PERSONA,
                                                            oListarPersona.TIPO_PERSONA,
                                                            oListarPersona.ID_GENERO,
                                                            oListarPersona.GENERO,
                                                            oListarPersona.NOMBRE,
                                                            oListarPersona.AP_PATERNO,
                                                            oListarPersona.AP_MATERNO,
                                                            oListarPersona.FECHA_NACIMIENTO,
                                                            oListarPersona.DIRECCION,
                                                            oListarPersona.EMAIL,
                                                            oListarPersona.APP_ID_USUARIO,
                                                            oListarPersona.AUD_ESTADO,
                                                            oListarPersona.FECHA_REGISTRO
                                                            ).ToList();
                    return objListado;
                }
                catch (Exception ex)
                {
                    strMensajeError = "Error 200: " + ex.Message + "-" + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objListado =
                        ctx.PGET_LISTADOS_P_LISTAR_DOCUMENTO(strCredencial,
                                                            oListarDocumento.ID_DOCUMENTO,
                                                            oListarDocumento.ID_PERSONA,
                                                            oListarDocumento.ID_TIPO_DOCUMENTO,
                                                            oListarDocumento.TIPO_DOCUMENTO,
                                                            oListarDocumento.NUMERO_DOCUMENTO,
                                                            oListarDocumento.DESCRIPCION,
                                                            oListarDocumento.APP_ID_USUARIO,
                                                            oListarDocumento.AUD_ESTADO,
                                                            oListarDocumento.FECHA_REGISTRO
                                                            ).ToList();
                    return objListado;
                }
                catch (Exception ex)
                {
                    strMensajeError = "Error 200: " + ex.Message + "-" + ex.InnerException;
                    return null;
                }
            }
        }
    }
}
