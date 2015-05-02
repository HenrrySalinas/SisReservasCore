using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DominioEntidades.SisReservas;

namespace DominioServicios.SisReservas.Interfaz
{
    public interface IDominioReportes
    {
        

        List<O_LISTAR_GENERO> ListarGenero(string strCredencial, O_LISTAR_GENERO oListarGenero, ref string strMensajeError);
        List<O_LISTAR_PERSONA> ListarPersona(string strCredencial, O_LISTAR_PERSONA oListarPersona, ref string strMensajeError);
        List<O_LISTAR_DOCUMENTO> ListarDocumento(string strCredencial, O_LISTAR_DOCUMENTO oListarDocumento, ref string strMensajeError);
        List<O_LISTAR_BOLETO_COMPLETO> ListarBoletoCompleto(string strCredencial, O_LISTAR_BOLETO_COMPLETO oListarBoletoCompleto, ref string strMensajeError);
        List<O_LISTAR_ASIENTO_COMPLETO> ListarAsientoCompleto(string strCredencial,  O_LISTAR_ASIENTO_COMPLETO oListarAsientoCompleto, ref string strMensajeError);
        List<O_LISTAR_RUTA_COMPLETO> ListarRutaCompleto(string strCredencial, O_LISTAR_RUTA_COMPLETO oListarRutaCompleto, ref string strMensajeError);

        List<O_CIUDAD> ListarCiudad(string strCredencial, O_CIUDAD oCiudad, ref string strMensajeError);
    }
}
