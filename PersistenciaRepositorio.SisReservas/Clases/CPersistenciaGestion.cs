using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DominioEntidades.SisReservas;
using DominioServicios.SisReservas.Interfaz;
using PersistenciaModelo.SisReservas;

namespace PersistenciaRepositorio.SisReservas.Clases
{
    public class CPersistenciaGestion:IDominioGestion
    {
        public List<O_RESULTADO> RegistrarGenero(string strCredencial, O_LISTAR_GENERO oGenero, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_GENERO(strCredencial, 
                                                             oGenero.ID_GENERO, 
                                                             oGenero.DESCRIPCION, 
                                                             oGenero.APP_ID_USUARIO, 
                                                             oGenero.AUD_ESTADO, 
                                                             oGenero.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarPersona(string strCredencial, O_LISTAR_PERSONA oPersona, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_PERSONA(strCredencial,
                                                             oPersona.ID_PERSONA,
                                                             oPersona.ID_TIPO_PERSONA,
                                                             oPersona.ID_GENERO,
                                                             oPersona.NOMBRE,
                                                             oPersona.AP_PATERNO,
                                                             oPersona.AP_MATERNO,
                                                             oPersona.FECHA_NACIMIENTO,
                                                             oPersona.DIRECCION,
                                                             oPersona.EMAIL,
                                                             oPersona.APP_ID_USUARIO,
                                                             oPersona.AUD_ESTADO,
                                                             oPersona.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRA_DOCUMENTO(strCredencial,
                                                             oDocumento.ID_DOCUMENTO,
                                                             oDocumento.ID_PERSONA,
                                                             oDocumento.ID_TIPO_DOCUMENTO,
                                                             oDocumento.NUMERO_DOCUMENTO,
                                                             oDocumento.DESCRIPCION,
                                                             oDocumento.APP_ID_USUARIO,
                                                             oDocumento.AUD_ESTADO,
                                                             oDocumento.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarBoleto(string strCredencial, O_BOLETO oBoleto, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_BOLETO(strCredencial,
                                                            oBoleto.ID_BOLETO,
                                                            oBoleto.ID_USUARIO,
                                                            oBoleto.ID_RUTA,
                                                            oBoleto.ID_SUCURSAL,
                                                            oBoleto.O_DATOS_AUD.APP_ID_USUARIO,
                                                            oBoleto.O_DATOS_AUD.AUD_ESTADO,
                                                            oBoleto.O_DATOS_AUD.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarAsiento(string strCredencial, O_ASIENTO oAsiento, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_ASIENTO(strCredencial,
                                                            oAsiento.ID_ASIENTO,
                                                            oAsiento.ID_TIPO_ASIENTO,
                                                            oAsiento.NUMERO,
                                                            oAsiento.O_DATOS_AUD.APP_ID_USUARIO,
                                                            oAsiento.O_DATOS_AUD.AUD_ESTADO,
                                                            oAsiento.O_DATOS_AUD.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarDetalleBoleto(string strCredencial, O_DETALLE_BOLETO oDetalleBoleto, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_DETALLE_BOLETO(strCredencial,
                                                            oDetalleBoleto.ID_DETALLE_BOLETO,
                                                            oDetalleBoleto.ID_BOLETO,
                                                            oDetalleBoleto.ID_ASIENTO,
                                                            oDetalleBoleto.ID_PERSONA,
                                                            oDetalleBoleto.O_DATOS_AUD.APP_ID_USUARIO,
                                                            oDetalleBoleto.O_DATOS_AUD.AUD_ESTADO,
                                                            oDetalleBoleto.O_DATOS_AUD.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarAsientoRuta(string strCredencial, O_ASIENTO_RUTA oAsientoRuta, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_ASIENTO_RUTA(strCredencial,
                                                            oAsientoRuta.ID_ASIENTO_RUTA,
                                                            oAsientoRuta.ID_RUTA,
                                                            oAsientoRuta.ID_ASIENTO,
                                                            oAsientoRuta.ID_ESTADO_ASIENTO,
                                                            oAsientoRuta.DESCRIPCION,
                                                            oAsientoRuta.O_DATOS_AUD.APP_ID_USUARIO,
                                                            oAsientoRuta.O_DATOS_AUD.AUD_ESTADO,
                                                            oAsientoRuta.O_DATOS_AUD.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }

        public List<O_RESULTADO> RegistrarRuta(string strCredencial, O_RUTA oRuta, ref string strMensajeError)
        {
            using (var ctx = new EntidadesSisReservas())
            {
                try
                {
                    var objResultado =
                        ctx.PGET_GESTION_P_REGISTRAR_RUTA(strCredencial,
                                                            oRuta.ID_RUTA,
                                                            oRuta.ID_CIUDAD_ORIGEN,
                                                            oRuta.ID_CIUDAD_DESTINO,
                                                            oRuta.ID_FLOTA,
                                                            oRuta.ID_HORARIO,
                                                            oRuta.ID_PRECIO,
                                                            oRuta.ID_CONDUCTOR,
                                                            oRuta.O_DATOS_AUD.APP_ID_USUARIO,
                                                            oRuta.O_DATOS_AUD.AUD_ESTADO,
                                                            oRuta.O_DATOS_AUD.FECHA_REGISTRO
                                                             ).ToList();

                    return objResultado;
                }
                catch (Exception ex)
                {

                    strMensajeError = "CPersistenciaRepositorio " + ex.Message + " " + ex.InnerException;
                    return null;
                }
            }
        }
    }
}
