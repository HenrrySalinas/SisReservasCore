//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios en este archivo pueden ocasionar un comportamiento incorrecto y se perderán si
//     el código se vuelve a generar.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace DominioEntidades.SisReservas
{
    
    public partial class O_BOLETO : INotifyComplexPropertyChanging, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public Nullable<decimal> ID_BOLETO
        {
            get { return _iD_BOLETO; }
            set
            {
                if (_iD_BOLETO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_BOLETO = value;
                    OnPropertyChanged("ID_BOLETO");
                }
            }
        }
        private Nullable<decimal> _iD_BOLETO;
    
        [DataMember]
        public Nullable<decimal> ID_USUARIO
        {
            get { return _iD_USUARIO; }
            set
            {
                if (_iD_USUARIO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_USUARIO = value;
                    OnPropertyChanged("ID_USUARIO");
                }
            }
        }
        private Nullable<decimal> _iD_USUARIO;
    
        [DataMember]
        public Nullable<decimal> ID_RUTA
        {
            get { return _iD_RUTA; }
            set
            {
                if (_iD_RUTA != value)
                {
                    OnComplexPropertyChanging();
                    _iD_RUTA = value;
                    OnPropertyChanged("ID_RUTA");
                }
            }
        }
        private Nullable<decimal> _iD_RUTA;
    
        [DataMember]
        public Nullable<decimal> ID_SUCURSAL
        {
            get { return _iD_SUCURSAL; }
            set
            {
                if (_iD_SUCURSAL != value)
                {
                    OnComplexPropertyChanging();
                    _iD_SUCURSAL = value;
                    OnPropertyChanged("ID_SUCURSAL");
                }
            }
        }
        private Nullable<decimal> _iD_SUCURSAL;

        #endregion

        #region Propiedades complejas
    
        [DataMember]
        public O_DATOS_AUD O_DATOS_AUD
        {
            get
            {
                if (!_o_DATOS_AUDInitialized && _o_DATOS_AUD == null)
                {
                    _o_DATOS_AUD = new O_DATOS_AUD();
                    ((INotifyComplexPropertyChanging)_o_DATOS_AUD).ComplexPropertyChanging += HandleComplexPropertyChanging;
                }
                _o_DATOS_AUDInitialized = true;
                return _o_DATOS_AUD;
            }
            set
            {
                _o_DATOS_AUDInitialized = true;
                if (!Equals(_o_DATOS_AUD, value))
                {
                    if (_o_DATOS_AUD != null)
                    {
                        ((INotifyComplexPropertyChanging)_o_DATOS_AUD).ComplexPropertyChanging -= HandleComplexPropertyChanging;
                    }
    
                    OnComplexPropertyChanging();
                    _o_DATOS_AUD = value;
                    OnPropertyChanged("O_DATOS_AUD");
    
                    if (value != null)
                    {
                        ((INotifyComplexPropertyChanging)value).ComplexPropertyChanging += HandleComplexPropertyChanging;
                    }
                }
            }
        }
        private O_DATOS_AUD _o_DATOS_AUD;
        private bool _o_DATOS_AUDInitialized;

        #endregion

        #region ChangeTracking
    
        private void OnComplexPropertyChanging()
        {
            if (_complexPropertyChanging != null)
            {
                _complexPropertyChanging(this, new EventArgs());
            }
        }
    
        event EventHandler INotifyComplexPropertyChanging.ComplexPropertyChanging { add { _complexPropertyChanging += value; } remove { _complexPropertyChanging -= value; } }
        private event EventHandler _complexPropertyChanging;
    
        private void OnPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged { add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    
        private void HandleComplexPropertyChanging(object sender, EventArgs args)
        {
            // Enviar el evento a todas las escuchas porque algo ha cambiado en una propiedad compleja anidada
            OnComplexPropertyChanging();
        }
    
        public static void RecordComplexOriginalValues(String parentPropertyName, O_BOLETO complexObject, ObjectChangeTracker changeTracker)
        {
            if (String.IsNullOrEmpty(parentPropertyName))
            {
                throw new ArgumentException("El parámetro de cadena no puede ser NULL ni estar vacío.", "parentPropertyName");
            }
    
            if (changeTracker == null)
            {
                throw new ArgumentNullException("changeTracker");
            }
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_BOLETO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_BOLETO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_USUARIO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_USUARIO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_RUTA", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_RUTA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_SUCURSAL", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_SUCURSAL);
            O_DATOS_AUD.RecordComplexOriginalValues(String.Format(CultureInfo.InvariantCulture, "{0}.O_DATOS_AUD", parentPropertyName), complexObject == null ? null : complexObject.O_DATOS_AUD, changeTracker);
        }

        #endregion

    }
}