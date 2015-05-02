using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DominioEntidades.SisReservas;

namespace DominioContratos.SisReservas
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        // Metodos que comprometen los datos en la persistencia de datos
        void RealizarCambios();
        void RegistrarCambios<TEntidad>(TEntidad entidad) where TEntidad : class, IObjectWithChangeTracker;
    }
}
