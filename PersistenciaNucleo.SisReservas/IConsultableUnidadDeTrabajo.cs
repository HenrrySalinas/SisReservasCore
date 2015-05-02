
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using DominioContratos.SisReservas;
using DominioEntidades.SisReservas;

namespace PersistenciaNucleo.SisReservas
{
    public interface IConsultableUnidadDeTrabajo : IUnidadDeTrabajo
    {
        // Crea el cotenxto para una determinada Entidad
        IObjectSet<TEntidad> CrearSet<TEntidad>() where TEntidad : class, IObjectWithChangeTracker;
    }
}
