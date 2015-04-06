﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios en este archivo pueden ocasionar un comportamiento incorrecto y se perderán si
//     el código se vuelve a generar.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using DominioEntidades.SisReservas;
using DominioContratos.SisReservas;
using PersistenciaNucleo.SisReservas;

namespace PersistenciaModelo.SisReservas
{
    public partial class EntidadesSisReservas : ObjectContext,IConsultableUnidadDeTrabajo
    {
    	public void RealizarCambios()
    	{
    		SaveChanges();
    	}
    
    	public void RegistrarCambios<TEntidad>(TEntidad entidad) where TEntidad : class, IObjectWithChangeTracker
    	{
    		this.CreateObjectSet<TEntidad>().ApplyChanges(entidad);
    	}
    
    	public IObjectSet<TEntidad> CrearSet<TEntidad>() where TEntidad : class, IObjectWithChangeTracker
    	{
    		return base.CreateObjectSet<TEntidad>() as IObjectSet<TEntidad>;
    	}
        public const string ConnectionString = "name=EntidadesSisReservas";
        public const string ContainerName = "EntidadesSisReservas";
    
        #region Constructors
    
        public EntidadesSisReservas()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public EntidadesSisReservas(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public EntidadesSisReservas(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // La creación de servidores proxy requiere el uso de ProxyDataContractResolver y
            // puede permitir la carga diferida que puede expandir el gráfico durante la serialización.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region Importaciones de funciones
        public virtual ObjectResult<O_LISTAR_GENERO> PGET_LISTADOS_P_LISTAR_GENERO(string i_CREDENCIAL, Nullable<decimal> i_ID_GENERO, string i_DESCRIPCION, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_GENEROParameter;
    
            if (i_ID_GENERO.HasValue)
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", i_ID_GENERO);
            }
            else
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", typeof(decimal));
            }
    
            ObjectParameter i_DESCRIPCIONParameter;
    
            if (i_DESCRIPCION != null)
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", i_DESCRIPCION);
            }
            else
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_LISTAR_GENERO>("PGET_LISTADOS_P_LISTAR_GENERO", i_CREDENCIALParameter, i_ID_GENEROParameter, i_DESCRIPCIONParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }
        public virtual ObjectResult<O_LISTAR_PERSONA> PGET_LISTADOS_P_LISTAR_PERSONA(string i_CREDENCIAL, Nullable<decimal> i_ID_PERSONA, Nullable<decimal> i_ID_TIPO_PERSONA, string i_TIPO_PERSONA, Nullable<decimal> i_ID_GENERO, string i_GENERO, string i_NOMBRE, string i_AP_PATERNO, string i_AP_MATERNO, Nullable<System.DateTime> i_FECHA_NACIMIENTO, string i_DIRECCION, string i_EMAIL, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_PERSONAParameter;
    
            if (i_ID_PERSONA.HasValue)
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", i_ID_PERSONA);
            }
            else
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_ID_TIPO_PERSONAParameter;
    
            if (i_ID_TIPO_PERSONA.HasValue)
            {
                i_ID_TIPO_PERSONAParameter = new ObjectParameter("I_ID_TIPO_PERSONA", i_ID_TIPO_PERSONA);
            }
            else
            {
                i_ID_TIPO_PERSONAParameter = new ObjectParameter("I_ID_TIPO_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_TIPO_PERSONAParameter;
    
            if (i_TIPO_PERSONA != null)
            {
                i_TIPO_PERSONAParameter = new ObjectParameter("I_TIPO_PERSONA", i_TIPO_PERSONA);
            }
            else
            {
                i_TIPO_PERSONAParameter = new ObjectParameter("I_TIPO_PERSONA", typeof(string));
            }
    
            ObjectParameter i_ID_GENEROParameter;
    
            if (i_ID_GENERO.HasValue)
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", i_ID_GENERO);
            }
            else
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", typeof(decimal));
            }
    
            ObjectParameter i_GENEROParameter;
    
            if (i_GENERO != null)
            {
                i_GENEROParameter = new ObjectParameter("I_GENERO", i_GENERO);
            }
            else
            {
                i_GENEROParameter = new ObjectParameter("I_GENERO", typeof(string));
            }
    
            ObjectParameter i_NOMBREParameter;
    
            if (i_NOMBRE != null)
            {
                i_NOMBREParameter = new ObjectParameter("I_NOMBRE", i_NOMBRE);
            }
            else
            {
                i_NOMBREParameter = new ObjectParameter("I_NOMBRE", typeof(string));
            }
    
            ObjectParameter i_AP_PATERNOParameter;
    
            if (i_AP_PATERNO != null)
            {
                i_AP_PATERNOParameter = new ObjectParameter("I_AP_PATERNO", i_AP_PATERNO);
            }
            else
            {
                i_AP_PATERNOParameter = new ObjectParameter("I_AP_PATERNO", typeof(string));
            }
    
            ObjectParameter i_AP_MATERNOParameter;
    
            if (i_AP_MATERNO != null)
            {
                i_AP_MATERNOParameter = new ObjectParameter("I_AP_MATERNO", i_AP_MATERNO);
            }
            else
            {
                i_AP_MATERNOParameter = new ObjectParameter("I_AP_MATERNO", typeof(string));
            }
    
            ObjectParameter i_FECHA_NACIMIENTOParameter;
    
            if (i_FECHA_NACIMIENTO.HasValue)
            {
                i_FECHA_NACIMIENTOParameter = new ObjectParameter("I_FECHA_NACIMIENTO", i_FECHA_NACIMIENTO);
            }
            else
            {
                i_FECHA_NACIMIENTOParameter = new ObjectParameter("I_FECHA_NACIMIENTO", typeof(System.DateTime));
            }
    
            ObjectParameter i_DIRECCIONParameter;
    
            if (i_DIRECCION != null)
            {
                i_DIRECCIONParameter = new ObjectParameter("I_DIRECCION", i_DIRECCION);
            }
            else
            {
                i_DIRECCIONParameter = new ObjectParameter("I_DIRECCION", typeof(string));
            }
    
            ObjectParameter i_EMAILParameter;
    
            if (i_EMAIL != null)
            {
                i_EMAILParameter = new ObjectParameter("I_EMAIL", i_EMAIL);
            }
            else
            {
                i_EMAILParameter = new ObjectParameter("I_EMAIL", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_LISTAR_PERSONA>("PGET_LISTADOS_P_LISTAR_PERSONA", i_CREDENCIALParameter, i_ID_PERSONAParameter, i_ID_TIPO_PERSONAParameter, i_TIPO_PERSONAParameter, i_ID_GENEROParameter, i_GENEROParameter, i_NOMBREParameter, i_AP_PATERNOParameter, i_AP_MATERNOParameter, i_FECHA_NACIMIENTOParameter, i_DIRECCIONParameter, i_EMAILParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }
        public virtual ObjectResult<O_LISTAR_DOCUMENTO> PGET_LISTADOS_P_LISTAR_DOCUMENTO(string i_CREDENCIAL, Nullable<decimal> i_ID_DOCUMENTO, Nullable<decimal> i_ID_PERSONA, Nullable<decimal> i_ID_TIPO_DOCUMENTO, string i_TIPO_DOCUMENTO, string i_NUMERO_DOCUMENTO, string i_DESCRIPCION, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_DOCUMENTOParameter;
    
            if (i_ID_DOCUMENTO.HasValue)
            {
                i_ID_DOCUMENTOParameter = new ObjectParameter("I_ID_DOCUMENTO", i_ID_DOCUMENTO);
            }
            else
            {
                i_ID_DOCUMENTOParameter = new ObjectParameter("I_ID_DOCUMENTO", typeof(decimal));
            }
    
            ObjectParameter i_ID_PERSONAParameter;
    
            if (i_ID_PERSONA.HasValue)
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", i_ID_PERSONA);
            }
            else
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_ID_TIPO_DOCUMENTOParameter;
    
            if (i_ID_TIPO_DOCUMENTO.HasValue)
            {
                i_ID_TIPO_DOCUMENTOParameter = new ObjectParameter("I_ID_TIPO_DOCUMENTO", i_ID_TIPO_DOCUMENTO);
            }
            else
            {
                i_ID_TIPO_DOCUMENTOParameter = new ObjectParameter("I_ID_TIPO_DOCUMENTO", typeof(decimal));
            }
    
            ObjectParameter i_TIPO_DOCUMENTOParameter;
    
            if (i_TIPO_DOCUMENTO != null)
            {
                i_TIPO_DOCUMENTOParameter = new ObjectParameter("I_TIPO_DOCUMENTO", i_TIPO_DOCUMENTO);
            }
            else
            {
                i_TIPO_DOCUMENTOParameter = new ObjectParameter("I_TIPO_DOCUMENTO", typeof(string));
            }
    
            ObjectParameter i_NUMERO_DOCUMENTOParameter;
    
            if (i_NUMERO_DOCUMENTO != null)
            {
                i_NUMERO_DOCUMENTOParameter = new ObjectParameter("I_NUMERO_DOCUMENTO", i_NUMERO_DOCUMENTO);
            }
            else
            {
                i_NUMERO_DOCUMENTOParameter = new ObjectParameter("I_NUMERO_DOCUMENTO", typeof(string));
            }
    
            ObjectParameter i_DESCRIPCIONParameter;
    
            if (i_DESCRIPCION != null)
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", i_DESCRIPCION);
            }
            else
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_LISTAR_DOCUMENTO>("PGET_LISTADOS_P_LISTAR_DOCUMENTO", i_CREDENCIALParameter, i_ID_DOCUMENTOParameter, i_ID_PERSONAParameter, i_ID_TIPO_DOCUMENTOParameter, i_TIPO_DOCUMENTOParameter, i_NUMERO_DOCUMENTOParameter, i_DESCRIPCIONParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }
        public virtual ObjectResult<O_RESULTADO> PGET_GESTION_P_REGISTRAR_PERSONA(string i_CREDENCIAL, Nullable<decimal> i_ID_PERSONA, Nullable<decimal> i_ID_TIPO_PERSONA, Nullable<decimal> i_ID_GENERO, string i_NOMBRE, string i_AP_PATERNO, string i_AP_MATERNO, Nullable<System.DateTime> i_FECHA_NACIMIENTO, string i_DIRECCION, string i_EMAIL, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_PERSONAParameter;
    
            if (i_ID_PERSONA.HasValue)
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", i_ID_PERSONA);
            }
            else
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_ID_TIPO_PERSONAParameter;
    
            if (i_ID_TIPO_PERSONA.HasValue)
            {
                i_ID_TIPO_PERSONAParameter = new ObjectParameter("I_ID_TIPO_PERSONA", i_ID_TIPO_PERSONA);
            }
            else
            {
                i_ID_TIPO_PERSONAParameter = new ObjectParameter("I_ID_TIPO_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_ID_GENEROParameter;
    
            if (i_ID_GENERO.HasValue)
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", i_ID_GENERO);
            }
            else
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", typeof(decimal));
            }
    
            ObjectParameter i_NOMBREParameter;
    
            if (i_NOMBRE != null)
            {
                i_NOMBREParameter = new ObjectParameter("I_NOMBRE", i_NOMBRE);
            }
            else
            {
                i_NOMBREParameter = new ObjectParameter("I_NOMBRE", typeof(string));
            }
    
            ObjectParameter i_AP_PATERNOParameter;
    
            if (i_AP_PATERNO != null)
            {
                i_AP_PATERNOParameter = new ObjectParameter("I_AP_PATERNO", i_AP_PATERNO);
            }
            else
            {
                i_AP_PATERNOParameter = new ObjectParameter("I_AP_PATERNO", typeof(string));
            }
    
            ObjectParameter i_AP_MATERNOParameter;
    
            if (i_AP_MATERNO != null)
            {
                i_AP_MATERNOParameter = new ObjectParameter("I_AP_MATERNO", i_AP_MATERNO);
            }
            else
            {
                i_AP_MATERNOParameter = new ObjectParameter("I_AP_MATERNO", typeof(string));
            }
    
            ObjectParameter i_FECHA_NACIMIENTOParameter;
    
            if (i_FECHA_NACIMIENTO.HasValue)
            {
                i_FECHA_NACIMIENTOParameter = new ObjectParameter("I_FECHA_NACIMIENTO", i_FECHA_NACIMIENTO);
            }
            else
            {
                i_FECHA_NACIMIENTOParameter = new ObjectParameter("I_FECHA_NACIMIENTO", typeof(System.DateTime));
            }
    
            ObjectParameter i_DIRECCIONParameter;
    
            if (i_DIRECCION != null)
            {
                i_DIRECCIONParameter = new ObjectParameter("I_DIRECCION", i_DIRECCION);
            }
            else
            {
                i_DIRECCIONParameter = new ObjectParameter("I_DIRECCION", typeof(string));
            }
    
            ObjectParameter i_EMAILParameter;
    
            if (i_EMAIL != null)
            {
                i_EMAILParameter = new ObjectParameter("I_EMAIL", i_EMAIL);
            }
            else
            {
                i_EMAILParameter = new ObjectParameter("I_EMAIL", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_RESULTADO>("PGET_GESTION_P_REGISTRAR_PERSONA", i_CREDENCIALParameter, i_ID_PERSONAParameter, i_ID_TIPO_PERSONAParameter, i_ID_GENEROParameter, i_NOMBREParameter, i_AP_PATERNOParameter, i_AP_MATERNOParameter, i_FECHA_NACIMIENTOParameter, i_DIRECCIONParameter, i_EMAILParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }
        public virtual ObjectResult<O_RESULTADO> PGET_GESTION_P_REGISTRAR_GENERO(string i_CREDENCIAL, Nullable<decimal> i_ID_GENERO, string i_DESCRIPCION, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_GENEROParameter;
    
            if (i_ID_GENERO.HasValue)
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", i_ID_GENERO);
            }
            else
            {
                i_ID_GENEROParameter = new ObjectParameter("I_ID_GENERO", typeof(decimal));
            }
    
            ObjectParameter i_DESCRIPCIONParameter;
    
            if (i_DESCRIPCION != null)
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", i_DESCRIPCION);
            }
            else
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_RESULTADO>("PGET_GESTION_P_REGISTRAR_GENERO", i_CREDENCIALParameter, i_ID_GENEROParameter, i_DESCRIPCIONParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }
        public virtual ObjectResult<O_RESULTADO> PGET_GESTION_P_REGISTRA_DOCUMENTO(string i_CREDENCIAL, Nullable<decimal> i_ID_DOCUMENTO, Nullable<decimal> i_ID_PERSONA, Nullable<decimal> i_ID_TIPO_DOCUMENTO, string i_NUMERO_DOCUMENTO, string i_DESCRIPCION, Nullable<decimal> i_APP_ID_USUARIO, Nullable<decimal> i_AUD_ESTADO, Nullable<System.DateTime> i_FECHA_REGISTRO)
        {
    
            ObjectParameter i_CREDENCIALParameter;
    
            if (i_CREDENCIAL != null)
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", i_CREDENCIAL);
            }
            else
            {
                i_CREDENCIALParameter = new ObjectParameter("I_CREDENCIAL", typeof(string));
            }
    
            ObjectParameter i_ID_DOCUMENTOParameter;
    
            if (i_ID_DOCUMENTO.HasValue)
            {
                i_ID_DOCUMENTOParameter = new ObjectParameter("I_ID_DOCUMENTO", i_ID_DOCUMENTO);
            }
            else
            {
                i_ID_DOCUMENTOParameter = new ObjectParameter("I_ID_DOCUMENTO", typeof(decimal));
            }
    
            ObjectParameter i_ID_PERSONAParameter;
    
            if (i_ID_PERSONA.HasValue)
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", i_ID_PERSONA);
            }
            else
            {
                i_ID_PERSONAParameter = new ObjectParameter("I_ID_PERSONA", typeof(decimal));
            }
    
            ObjectParameter i_ID_TIPO_DOCUMENTOParameter;
    
            if (i_ID_TIPO_DOCUMENTO.HasValue)
            {
                i_ID_TIPO_DOCUMENTOParameter = new ObjectParameter("I_ID_TIPO_DOCUMENTO", i_ID_TIPO_DOCUMENTO);
            }
            else
            {
                i_ID_TIPO_DOCUMENTOParameter = new ObjectParameter("I_ID_TIPO_DOCUMENTO", typeof(decimal));
            }
    
            ObjectParameter i_NUMERO_DOCUMENTOParameter;
    
            if (i_NUMERO_DOCUMENTO != null)
            {
                i_NUMERO_DOCUMENTOParameter = new ObjectParameter("I_NUMERO_DOCUMENTO", i_NUMERO_DOCUMENTO);
            }
            else
            {
                i_NUMERO_DOCUMENTOParameter = new ObjectParameter("I_NUMERO_DOCUMENTO", typeof(string));
            }
    
            ObjectParameter i_DESCRIPCIONParameter;
    
            if (i_DESCRIPCION != null)
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", i_DESCRIPCION);
            }
            else
            {
                i_DESCRIPCIONParameter = new ObjectParameter("I_DESCRIPCION", typeof(string));
            }
    
            ObjectParameter i_APP_ID_USUARIOParameter;
    
            if (i_APP_ID_USUARIO.HasValue)
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", i_APP_ID_USUARIO);
            }
            else
            {
                i_APP_ID_USUARIOParameter = new ObjectParameter("I_APP_ID_USUARIO", typeof(decimal));
            }
    
            ObjectParameter i_AUD_ESTADOParameter;
    
            if (i_AUD_ESTADO.HasValue)
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", i_AUD_ESTADO);
            }
            else
            {
                i_AUD_ESTADOParameter = new ObjectParameter("I_AUD_ESTADO", typeof(decimal));
            }
    
            ObjectParameter i_FECHA_REGISTROParameter;
    
            if (i_FECHA_REGISTRO.HasValue)
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", i_FECHA_REGISTRO);
            }
            else
            {
                i_FECHA_REGISTROParameter = new ObjectParameter("I_FECHA_REGISTRO", typeof(System.DateTime));
            }
            return base.ExecuteFunction<O_RESULTADO>("PGET_GESTION_P_REGISTRA_DOCUMENTO", i_CREDENCIALParameter, i_ID_DOCUMENTOParameter, i_ID_PERSONAParameter, i_ID_TIPO_DOCUMENTOParameter, i_NUMERO_DOCUMENTOParameter, i_DESCRIPCIONParameter, i_APP_ID_USUARIOParameter, i_AUD_ESTADOParameter, i_FECHA_REGISTROParameter);
        }

        #endregion
    }
}
