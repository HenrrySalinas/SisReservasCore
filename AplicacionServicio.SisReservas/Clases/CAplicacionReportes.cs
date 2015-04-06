using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionServicio.SisReservas.Interfaz;
using DominioEntidades.SisReservas;
using DominioServicios.SisReservas.Interfaz;

namespace AplicacionServicio.SisReservas.Clases
{
    public class CAplicacionReportes : IAplicacionReportes
    {
        private readonly IDominioReportes _repositorioReportes;
        public CAplicacionReportes(IDominioReportes repositorioReportes)
        {
            _repositorioReportes = repositorioReportes;
        }


        public List<O_LISTAR_GENERO> ListarGenero(string strCredencial, O_LISTAR_GENERO oListarGenero, ref string strMensajeError)
        {
            try
            {
                var objListado =
                    _repositorioReportes.ListarGenero(strCredencial, oListarGenero, ref strMensajeError);
                return objListado;
            }
            catch (Exception ex)
            {
                strMensajeError = "CAplicacionListados: method ListarFeriados(...)" + System.Reflection.MethodBase.GetCurrentMethod().Name +
                                      "Error 300:" + ex.Message + '-' + ex.InnerException;
                return null;
            }
        }

        public List<O_LISTAR_PERSONA> ListarPersona(string strCredencial, O_LISTAR_PERSONA oListarPersona, ref string strMensajeError)
        {
            try
            {
                var objListado =
                    _repositorioReportes.ListarPersona(strCredencial, oListarPersona, ref strMensajeError);
                return objListado;
            }
            catch (Exception ex)
            {
                strMensajeError = "CAplicacionListados: method ListarFeriados(...)" + System.Reflection.MethodBase.GetCurrentMethod().Name +
                                      "Error 300:" + ex.Message + '-' + ex.InnerException;
                return null;
            }
        }

        public List<O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError)
        {
            try
            {
                var objListado =
                    _repositorioReportes.ListarDocumento(strCredencial, oListarDocumento, ref strMensajeError);
                return objListado;
            }
            catch (Exception ex)
            {
                strMensajeError = "CAplicacionListados: method ListarFeriados(...)" + System.Reflection.MethodBase.GetCurrentMethod().Name +
                                      "Error 300:" + ex.Message + '-' + ex.InnerException;
                return null;
            }
        }
    }
}
