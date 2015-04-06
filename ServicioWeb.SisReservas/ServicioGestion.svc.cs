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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGestion" en el código, en svc y en el archivo de configuración a la vez.
    public class ServicioGestion : IServicioGestion
    {

        public List<O_RESULTADO> RegistrarGenero(string strCredencial, O_LISTAR_GENERO oGenero, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionGestion>();
                return _servicio.RegistrarGenero(strCredencial, oGenero, ref strMensajeError);

            }
            catch (Exception e )
            {
                strMensajeError += e.Message + " - " + e.InnerException;
                return null;

            }
        }

        public List<O_RESULTADO> RegistrarPersona(string strCredencial, O_LISTAR_PERSONA oPersona, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionGestion>();
                return _servicio.RegistrarPersona(strCredencial, oPersona, ref strMensajeError);

            }
            catch (Exception e)
            {
                strMensajeError += e.Message + " - " + e.InnerException;
                return null;

            }
        }

        public List<O_RESULTADO> RegistrarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError)
        {
            try
            {
                var _servicio = FabricaIoC.Contenedor.Resolver<IAplicacionGestion>();
                return _servicio.RegistrarDocumento(strCredencial, oDocumento, ref strMensajeError);

            }
            catch (Exception e)
            {
                strMensajeError += e.Message + " - " + e.InnerException;
                return null;

            }
        }
    }
}
