using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DominioEntidades.SisReservas;

namespace ServicioWeb.SisReservas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReportes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReportes
    {
        
        [OperationContract]
        List<O_LISTAR_GENERO> ListarGenero(string strCredencial, O_LISTAR_GENERO oListarGenero, ref string strMensajeError);
        [OperationContract]
        List<O_LISTAR_PERSONA> ListarPersona(string strCredencial, O_LISTAR_PERSONA oListarPersona,ref string strMensajeError);
        [OperationContract]
        List<O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError);
    }
}
