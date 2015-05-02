using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AplicacionServicio.SisReservas.Clases;
using AplicacionServicio.SisReservas.Interfaz;
using DominioEntidades.SisReservas;
using DominioServicios.SisReservas.Interfaz;
using Microsoft.Practices.Unity;
using PersistenciaModelo.SisReservas;
using PersistenciaNucleo.SisReservas;
using PersistenciaRepositorio.SisReservas.Clases;

namespace PersistenciaUnity.SisReservas
{
    public class FabricaIoC
    {
        // Contenedor o Fabrica, libreria de Microsot Unity
        private static readonly FabricaIoC _contenedor = new FabricaIoC();
        private readonly IUnityContainer _unityContainer;

        private FabricaIoC()
        {

            _unityContainer = new UnityContainer();

            // Registrar los tipos utilizados en la aplicacion.
            // Especificamente con una nueva tecnologia de acceso a datos.

            #region Contenedores de los repositorios de la Capa de Persistencia

            _unityContainer.RegisterType<IDominioGestion, CPersistenciaGestion>();
            _unityContainer.RegisterType<IDominioListados, CPersistenciaListados>();
            _unityContainer.RegisterType<IDominioConsultas, CPersistenciaConsultas>();
            _unityContainer.RegisterType<IDominioReportes, CPersistenciaReportes>();
            //_unityContainer.RegisterType<IDominioSirhViaticos, CPersistenciaSirh>();


            #endregion

            #region Contenedores de los servicios de la Capa de Aplicacion

            _unityContainer.RegisterType<IAplicacionGestion, CAplicacionGestion>();
            _unityContainer.RegisterType<IAplicacionListados, CAplicacionListados>();
            _unityContainer.RegisterType<IAplicacionConsultas, CAplicacionConsultas>();
            _unityContainer.RegisterType<IAplicacionReportes, CAplicacionReportes>();
            //_unityContainer.RegisterType<IAplicacionSirh, CAplicacionSirh>();

            #endregion

            #region Contenedores de las Unidades de Trabajo y el Contexto

            _unityContainer.RegisterType<IConsultableUnidadDeTrabajo,EntidadesSisReservas>();

            #endregion

        }

        public static FabricaIoC Contenedor
        {
            get { return _contenedor; }
        }

        // Crear una instancia de un objeto que implemente un tipo TServicio.
        // Tipo de servicio que deseamos resolver

        public TServicio Resolver<TServicio>() where TServicio : class
        {
            return _unityContainer.Resolve<TServicio>();
        }
    }
}
