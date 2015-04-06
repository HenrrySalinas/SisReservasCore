using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using DominioContratos.SisReservas;
using DominioEntidades.SisReservas;

namespace PersistenciaNucleo.SisReservas
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class , IObjectWithChangeTracker
    {
        private readonly IConsultableUnidadDeTrabajo _unidadDeTrabajo;

        public Repositorio(IConsultableUnidadDeTrabajo unidadDeTrabajo)
        {
            if (unidadDeTrabajo == null)
            {
                throw new ArgumentNullException("unidadDeTrabajo", "La unidad de trabajo no puede ser null.");
            }
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        #region IRepositorio<TEntidad> Members

        public IUnidadDeTrabajo UnidadDeTrabajo
        {
            get { return _unidadDeTrabajo; }
        }

        public void Agregar(TEntidad entidad)
        {
            if (entidad == null)
            {
                throw new ArgumentNullException("entidad", "La entidad no puede ser null.");
            }
            if (entidad.ChangeTracker != null && entidad.ChangeTracker.State == ObjectState.Added)
            {
                _unidadDeTrabajo.RegistrarCambios(entidad);
            }
        }

        public void Remover(TEntidad entidad)
        {
            if (entidad == null)
            {
                throw new ArgumentNullException("entidad", "La entidad no puede ser null.");
            }
            IObjectSet<TEntidad> objectSet = _unidadDeTrabajo.CrearSet<TEntidad>();
            objectSet.Attach(entidad);
            objectSet.DeleteObject(entidad);
        }

        public void Modificar(TEntidad entidad)
        {
            if (entidad == null)
            {
                throw new ArgumentNullException("entidad", "La entidad no puede ser null.");
            }
            if (entidad.ChangeTracker != null && (entidad.ChangeTracker.State & ObjectState.Deleted) != ObjectState.Deleted)
            {
                entidad.MarkAsModified();
            }
            _unidadDeTrabajo.RegistrarCambios(entidad);
        }

        public IEnumerable<TEntidad> Obtener()
        {
            return _unidadDeTrabajo.CrearSet<TEntidad>().AsEnumerable();
        }

        #endregion
    }
}
