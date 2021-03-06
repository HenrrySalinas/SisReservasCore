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
    
    public partial class O_DETALLE_BOLETO : INotifyComplexPropertyChanging, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public Nullable<decimal> ID_DETALLE_BOLETO
        {
            get { return _iD_DETALLE_BOLETO; }
            set
            {
                if (_iD_DETALLE_BOLETO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_DETALLE_BOLETO = value;
                    OnPropertyChanged("ID_DETALLE_BOLETO");
                }
            }
        }
        private Nullable<decimal> _iD_DETALLE_BOLETO;
    
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
        public Nullable<decimal> ID_ASIENTO
        {
            get { return _iD_ASIENTO; }
            set
            {
                if (_iD_ASIENTO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_ASIENTO = value;
                    OnPropertyChanged("ID_ASIENTO");
                }
            }
        }
        private Nullable<decimal> _iD_ASIENTO;
    
        [DataMember]
        public Nullable<decimal> ID_PERSONA
        {
            get { return _iD_PERSONA; }
            set
            {
                if (_iD_PERSONA != value)
                {
                    OnComplexPropertyChanging();
                    _iD_PERSONA = value;
                    OnPropertyChanged("ID_PERSONA");
                }
            }
        }
        private Nullable<decimal> _iD_PERSONA;

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
    
        public static void RecordComplexOriginalValues(String parentPropertyName, O_DETALLE_BOLETO complexObject, ObjectChangeTracker changeTracker)
        {
            if (String.IsNullOrEmpty(parentPropertyName))
            {
                throw new ArgumentException("El parámetro de cadena no puede ser NULL ni estar vacío.", "parentPropertyName");
            }
    
            if (changeTracker == null)
            {
                throw new ArgumentNullException("changeTracker");
            }
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_DETALLE_BOLETO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_DETALLE_BOLETO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_BOLETO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_BOLETO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_ASIENTO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_ASIENTO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_PERSONA", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_PERSONA);
            O_DATOS_AUD.RecordComplexOriginalValues(String.Format(CultureInfo.InvariantCulture, "{0}.O_DATOS_AUD", parentPropertyName), complexObject == null ? null : complexObject.O_DATOS_AUD, changeTracker);
        }

        #endregion

    }
}
