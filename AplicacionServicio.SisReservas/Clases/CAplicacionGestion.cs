using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionServicio.SisReservas.Interfaz;
using DominioEntidades.SisReservas;
using DominioServicios.SisReservas.Interfaz;

namespace AplicacionServicio.SisReservas.Clases
{
    public class CAplicacionGestion:IAplicacionGestion
    {

        private readonly IDominioGestion _repositorioGestion;

        public CAplicacionGestion(IDominioGestion repositorioGestion)
        {
            _repositorioGestion = repositorioGestion;
        }

        public List<O_RESULTADO> RegistrarGenero(string strCredencial, O_LISTAR_GENERO oGenero, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarGenero(strCredencial, oGenero, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarPersona(string strCredencial, O_LISTAR_PERSONA oPersona, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarPersona(strCredencial, oPersona, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarDocumento(strCredencial, oDocumento, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarBoleto(string strCredencial, O_BOLETO oBoleto, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarBoleto(strCredencial, oBoleto, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarAsiento(string strCredencial, O_ASIENTO oAsiento, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarAsiento(strCredencial, oAsiento, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarDetalleBoleto(string strCredencial, O_DETALLE_BOLETO oDetalleBoleto, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarDetalleBoleto(strCredencial, oDetalleBoleto, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarAsientoRuta(string strCredencial, O_ASIENTO_RUTA oAsientoRuta, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarAsientoRuta(strCredencial, oAsientoRuta, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }

        public List<O_RESULTADO> RegistrarRuta(string strCredencial, O_RUTA oRuta, ref string strMensajeError)
        {
            try
            {
                return _repositorioGestion.RegistrarRuta(strCredencial, oRuta, ref strMensajeError).ToList();

            }
            catch (Exception ex)
            {

                strMensajeError = "Aplicacion Error " + System.Reflection.MethodBase.GetCurrentMethod().Name + "Error: " +
                                  ex.InnerException;
                return null;
            }
        }
    }
}
