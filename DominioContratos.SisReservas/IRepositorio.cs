using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominioContratos.SisReservas
{
    public interface IRepositorio<TEntidad> where TEntidad : class
    {
        IUnidadDeTrabajo UnidadDeTrabajo { get; }
        void Agregar(TEntidad entidad);
        void Remover(TEntidad entidad);
        void Modificar(TEntidad entidad);
        IEnumerable<TEntidad> Obtener();
    }
}
