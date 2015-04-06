using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicacionServicio.SisReservas.Interfaz;
using DominioEntidades.SisReservas;
using PersistenciaUnity.SisReservas;

namespace ServicioWeb.SisReservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReportes" en el código, en svc y en el archivo de configuración a la vez.
    public class ServicioReportes : IServicioReportes
    {
        public void DoWork()
        {
        }

        public List<O_LISTAR_GENERO> ListarGenero(string strCredencial, O_LISTAR_GENERO oListarGenero, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionReportes>();
                return _servicio.ListarGenero(strCredencial, oListarGenero, ref strMensajeError).ToList();
            }
            catch (Exception e)
            {
                strMensajeError += e.Message + " error 500: " + e.InnerException;
                return null;
            }
        }

        public List<O_LISTAR_PERSONA> ListarPersona(string strCredencial, O_LISTAR_PERSONA oListarPersona, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionReportes>();
                return _servicio.ListarPersona(strCredencial, oListarPersona, ref strMensajeError).ToList();
            }
            catch (Exception e)
            {
                strMensajeError += e.Message + " error 500: " + e.InnerException;
                return null;
            }
        }

        public List<O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionReportes>();
                return _servicio.ListarDocumento(strCredencial, oListarDocumento, ref strMensajeError).ToList();
            }
            catch (Exception e)
            {
                strMensajeError += e.Message + " error 500: " + e.InnerException;
                return null;
            }
        }
    }
}
