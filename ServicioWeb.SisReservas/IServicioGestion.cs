using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DominioEntidades.SisReservas;

namespace ServicioWeb.SisReservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioGestion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioGestion
    {
        [OperationContract]
        List<O_RESULTADO> RegistrarGenero(string strCredencial, O_LISTAR_GENERO oGenero, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarPersona(string strCredencial, O_LISTAR_PERSONA oPersona, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarBoleto(string strCredencial, O_BOLETO oBoleto, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarAsiento(string strCredencial, O_ASIENTO oAsiento, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarDetalleBoleto(string strCredencial, O_DETALLE_BOLETO oDetalleBoleto, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarAsientoRuta(string strCredencial, O_ASIENTO_RUTA oAsientoRuta, ref string strMensajeError);
        [OperationContract]
        List<O_RESULTADO> RegistrarRuta(string strCredencial, O_RUTA oRuta, ref string strMensajeError);
    }
}
