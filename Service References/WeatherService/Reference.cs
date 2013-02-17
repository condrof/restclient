﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace restClient.WeatherService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherInfo", Namespace="http://johnwalsh.com")]
    [System.SerializableAttribute()]
    public partial class WeatherInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private restClient.WeatherService.WeatherDescription weatherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private restClient.WeatherService.WindInfo windInfoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public restClient.WeatherService.WeatherDescription weather {
            get {
                return this.weatherField;
            }
            set {
                if ((this.weatherField.Equals(value) != true)) {
                    this.weatherField = value;
                    this.RaisePropertyChanged("weather");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public restClient.WeatherService.WindInfo windInfo {
            get {
                return this.windInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.windInfoField, value) != true)) {
                    this.windInfoField = value;
                    this.RaisePropertyChanged("windInfo");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WindInfo", Namespace="http://johnwalsh.com")]
    [System.SerializableAttribute()]
    public partial class WindInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float AvgWindSpeed_KMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float windSpeed_KMField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float AvgWindSpeed_KM {
            get {
                return this.AvgWindSpeed_KMField;
            }
            set {
                if ((this.AvgWindSpeed_KMField.Equals(value) != true)) {
                    this.AvgWindSpeed_KMField = value;
                    this.RaisePropertyChanged("AvgWindSpeed_KM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float windSpeed_KM {
            get {
                return this.windSpeed_KMField;
            }
            set {
                if ((this.windSpeed_KMField.Equals(value) != true)) {
                    this.windSpeed_KMField = value;
                    this.RaisePropertyChanged("windSpeed_KM");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherDescription", Namespace="http://schemas.datacontract.org/2004/07/JohnsRestWeatherService.DataContracts")]
    public enum WeatherDescription : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sunny = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rain = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cloudy = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://johnwalsh.com", ConfigurationName="WeatherService.IRestWeatherService")]
    public interface IRestWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://johnwalsh.com/IRestWeatherService/GetWeather", ReplyAction="http://johnwalsh.com/IRestWeatherService/GetWeatherResponse")]
        restClient.WeatherService.WeatherInfo GetWeather(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://johnwalsh.com/IRestWeatherService/UpdateWeather", ReplyAction="http://johnwalsh.com/IRestWeatherService/UpdateWeatherResponse")]
        string UpdateWeather(restClient.WeatherService.WeatherInfo info);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestWeatherServiceChannel : restClient.WeatherService.IRestWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestWeatherServiceClient : System.ServiceModel.ClientBase<restClient.WeatherService.IRestWeatherService>, restClient.WeatherService.IRestWeatherService {
        
        public RestWeatherServiceClient() {
        }
        
        public RestWeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestWeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestWeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestWeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public restClient.WeatherService.WeatherInfo GetWeather(string city) {
            return base.Channel.GetWeather(city);
        }
        
        public string UpdateWeather(restClient.WeatherService.WeatherInfo info) {
            return base.Channel.UpdateWeather(info);
        }
    }
}
