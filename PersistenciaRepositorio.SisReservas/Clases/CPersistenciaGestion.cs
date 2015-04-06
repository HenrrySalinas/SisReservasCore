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
    }
}
