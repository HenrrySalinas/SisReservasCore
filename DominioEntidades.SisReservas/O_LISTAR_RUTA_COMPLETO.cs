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
    
    public partial class O_LISTAR_RUTA_COMPLETO : INotifyComplexPropertyChanging, INotifyPropertyChanged
    {
        #region Propiedades primitivas
    
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
        public Nullable<decimal> ID_CIUDAD_ORIGEN
        {
            get { return _iD_CIUDAD_ORIGEN; }
            set
            {
                if (_iD_CIUDAD_ORIGEN != value)
                {
                    OnComplexPropertyChanging();
                    _iD_CIUDAD_ORIGEN = value;
                    OnPropertyChanged("ID_CIUDAD_ORIGEN");
                }
            }
        }
        private Nullable<decimal> _iD_CIUDAD_ORIGEN;
    
        [DataMember]
        public Nullable<decimal> ID_CIUDAD_DESTINO
        {
            get { return _iD_CIUDAD_DESTINO; }
            set
            {
                if (_iD_CIUDAD_DESTINO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_CIUDAD_DESTINO = value;
                    OnPropertyChanged("ID_CIUDAD_DESTINO");
                }
            }
        }
        private Nullable<decimal> _iD_CIUDAD_DESTINO;
    
        [DataMember]
        public Nullable<decimal> ID_FLOTA
        {
            get { return _iD_FLOTA; }
            set
            {
                if (_iD_FLOTA != value)
                {
                    OnComplexPropertyChanging();
                    _iD_FLOTA = value;
                    OnPropertyChanged("ID_FLOTA");
                }
            }
        }
        private Nullable<decimal> _iD_FLOTA;
    
        [DataMember]
        public Nullable<decimal> ID_HORARIO
        {
            get { return _iD_HORARIO; }
            set
            {
                if (_iD_HORARIO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_HORARIO = value;
                    OnPropertyChanged("ID_HORARIO");
                }
            }
        }
        private Nullable<decimal> _iD_HORARIO;
    
        [DataMember]
        public Nullable<decimal> ID_PRECIO
        {
            get { return _iD_PRECIO; }
            set
            {
                if (_iD_PRECIO != value)
                {
                    OnComplexPropertyChanging();
                    _iD_PRECIO = value;
                    OnPropertyChanged("ID_PRECIO");
                }
            }
        }
        private Nullable<decimal> _iD_PRECIO;
    
        [DataMember]
        public Nullable<decimal> ID_CONDUCTOR
        {
            get { return _iD_CONDUCTOR; }
            set
            {
                if (_iD_CONDUCTOR != value)
                {
                    OnComplexPropertyChanging();
                    _iD_CONDUCTOR = value;
                    OnPropertyChanged("ID_CONDUCTOR");
                }
            }
        }
        private Nullable<decimal> _iD_CONDUCTOR;
    
        [DataMember]
        public Nullable<decimal> PRECIO
        {
            get { return _pRECIO; }
            set
            {
                if (_pRECIO != value)
                {
                    OnComplexPropertyChanging();
                    _pRECIO = value;
                    OnPropertyChanged("PRECIO");
                }
            }
        }
        private Nullable<decimal> _pRECIO;
    
        [DataMember]
        public string HORA
        {
            get { return _hORA; }
            set
            {
                if (_hORA != value)
                {
                    OnComplexPropertyChanging();
                    _hORA = value;
                    OnPropertyChanged("HORA");
                }
            }
        }
        private string _hORA;
    
        [DataMember]
        public Nullable<decimal> ID_TIPO_FLOTA
        {
            get { return _iD_TIPO_FLOTA; }
            set
            {
                if (_iD_TIPO_FLOTA != value)
                {
                    OnComplexPropertyChanging();
                    _iD_TIPO_FLOTA = value;
                    OnPropertyChanged("ID_TIPO_FLOTA");
                }
            }
        }
        private Nullable<decimal> _iD_TIPO_FLOTA;
    
        [DataMember]
        public string PLACA
        {
            get { return _pLACA; }
            set
            {
                if (_pLACA != value)
                {
                    OnComplexPropertyChanging();
                    _pLACA = value;
                    OnPropertyChanged("PLACA");
                }
            }
        }
        private string _pLACA;
    
        [DataMember]
        public string MODELO
        {
            get { return _mODELO; }
            set
            {
                if (_mODELO != value)
                {
                    OnComplexPropertyChanging();
                    _mODELO = value;
                    OnPropertyChanged("MODELO");
                }
            }
        }
        private string _mODELO;
    
        [DataMember]
        public Nullable<decimal> NRO_ASIENTOS
        {
            get { return _nRO_ASIENTOS; }
            set
            {
                if (_nRO_ASIENTOS != value)
                {
                    OnComplexPropertyChanging();
                    _nRO_ASIENTOS = value;
                    OnPropertyChanged("NRO_ASIENTOS");
                }
            }
        }
        private Nullable<decimal> _nRO_ASIENTOS;
    
        [DataMember]
        public string TIPO_FLOTA
        {
            get { return _tIPO_FLOTA; }
            set
            {
                if (_tIPO_FLOTA != value)
                {
                    OnComplexPropertyChanging();
                    _tIPO_FLOTA = value;
                    OnPropertyChanged("TIPO_FLOTA");
                }
            }
        }
        private string _tIPO_FLOTA;
    
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
    
        public static void RecordComplexOriginalValues(String parentPropertyName, O_LISTAR_RUTA_COMPLETO complexObject, ObjectChangeTracker changeTracker)
        {
            if (String.IsNullOrEmpty(parentPropertyName))
            {
                throw new ArgumentException("El parámetro de cadena no puede ser NULL ni estar vacío.", "parentPropertyName");
            }
    
            if (changeTracker == null)
            {
                throw new ArgumentNullException("changeTracker");
            }
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_RUTA", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_RUTA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_CIUDAD_ORIGEN", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_CIUDAD_ORIGEN);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_CIUDAD_DESTINO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_CIUDAD_DESTINO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_FLOTA", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_FLOTA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_HORARIO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_HORARIO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_PRECIO", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_PRECIO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_CONDUCTOR", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_CONDUCTOR);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.PRECIO", parentPropertyName), complexObject == null ? null : (object)complexObject.PRECIO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.HORA", parentPropertyName), complexObject == null ? null : (object)complexObject.HORA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.ID_TIPO_FLOTA", parentPropertyName), complexObject == null ? null : (object)complexObject.ID_TIPO_FLOTA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.PLACA", parentPropertyName), complexObject == null ? null : (object)complexObject.PLACA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.MODELO", parentPropertyName), complexObject == null ? null : (object)complexObject.MODELO);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.NRO_ASIENTOS", parentPropertyName), complexObject == null ? null : (object)complexObject.NRO_ASIENTOS);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.TIPO_FLOTA", parentPropertyName), complexObject == null ? null : (object)complexObject.TIPO_FLOTA);
            changeTracker.RecordOriginalValue(String.Format(CultureInfo.InvariantCulture, "{0}.AUD_ESTADO", parentPropertyName), complexObject == null ? null : (object)complexObject.AUD_ESTADO);
        }

        #endregion

    }
}