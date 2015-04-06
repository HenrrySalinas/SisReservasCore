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
    }
}
