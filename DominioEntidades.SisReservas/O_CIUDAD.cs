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
    
    public partial class O_CIUDAD : INotifyComplexPropertyChanging, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
        [DataMember]
        public Nullable<decimal> ID_CIUDAD
        {
            get { return _iD_CIUDAD; }
            set
            {
                if (_iD_CIUDAD != value)
                {
                    OnComplexPropertyChanging();
                    _iD_CIUDAD = value;
                    OnPropertyChanged("ID_CIUDAD");
                }
            }
        }
        private Nullable<decimal> _iD_CIUDAD;
    
        [DataMember]
        public string CIUDAD
        {
            get { return _cIUDAD; }
            set
            {
                if (_cIUDAD != value)
                {
                    OnComplexPropertyChanging();
                    _cIUDAD = value;
                    OnPropertyChanged("CIUDAD");
                }
            }
        }
        private string _cIUDAD;
    
        [DataMember]
        public Nullable<decimal> AUD_ESTADO
        {
            get { return _aUD_ESTADO; }
            set
            {
                if (_aUD_ESTADO != value)
                {
                    OnComplexPropertyChanging();
                    _aUD_ESTADO = value;
                    OnPropertyChanged("AUD_ESTADO");
                }
            }
        }
        private Nullable<decimal> _aUD_ESTADO;

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
    
        public static void RecordComplexOriginalValues(String parentPropertyName, O_CIUDAD complexObject, ObjectChangeTracker changeTracker)
        {
            if (String.IsNullOrEmpty(parentPropertyName))
            {
                throw new ArgumentException("El parámetro de cadena no puede ser NULL ni estar vacío.", "parentPropertyName");
            }
    
            if (changeTracker == null)
            {
                throw new ArgumentNullException("changeTracker");
            }
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_CIUDAD", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_CIUDAD);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.CIUDAD", parentPropertyName), complexObject == null ? null : (object)complexObject.CIUDAD);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.AUD_ESTADO", parentPropertyName), complexObject == null ? null : (object)complexObject.AUD_ESTADO);
        }

        #endregion

    }
}