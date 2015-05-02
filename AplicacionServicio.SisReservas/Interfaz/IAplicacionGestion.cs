using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DominioEntidades.SisReservas;

namespace AplicacionServicio.SisReservas.Interfaz
{
    public interface IAplicacionGestion
    {
        List<O_RESULTADO> RegistrarGenero(string strCredencial, O_LISTAR_GENERO oGenero, ref string strMensajeError);

        List<O_RESULTADO> RegistrarPersona(string strCredencial, O_LISTAR_PERSONA oPersona, ref string strMensajeError);

        List<O_RESULTADO> RegistrarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oDocumento, ref string strMensajeError);
        List<O_RESULTADO> RegistrarBoleto(string strCredencial, O_BOLETO oBoleto, ref string strMensajeError);
        List<O_RESULTADO> RegistrarAsiento(string strCredencial, O_ASIENTO oAsiento, ref string strMensajeError);
        List<O_RESULTADO> RegistrarDetalleBoleto(string strCredencial, O_DETALLE_BOLETO oDetalleBoleto, ref string strMensajeError);
        List<O_RESULTADO> RegistrarAsientoRuta(string strCredencial, O_ASIENTO_RUTA oAsientoRuta, ref string strMensajeError);
        List<O_RESULTADO> RegistrarRuta(string strCredencial, O_RUTA oRuta, ref string strMensajeError);
    }
}
