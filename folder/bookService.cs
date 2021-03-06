﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://johnwalsh.com", ClrNamespace="johnwalsh.com")]

namespace johnwalsh.com
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookInfo", Namespace="http://johnwalsh.com")]
    public partial class BookInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PagesField;
        
        private string nameField;
        
        private bool paperbackField;
        
        private double priceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pages
        {
            get
            {
                return this.PagesField;
            }
            set
            {
                this.PagesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool paperback
        {
            get
            {
                return this.paperbackField;
            }
            set
            {
                this.paperbackField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://johnwalsh.com", ConfigurationName="IBookService")]
public interface IBookService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://johnwalsh.com/IBookService/GetBook", ReplyAction="http://johnwalsh.com/IBookService/GetBookResponse")]
    johnwalsh.com.BookInfo GetBook(double price);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://johnwalsh.com/IBookService/UpdateBook", ReplyAction="http://johnwalsh.com/IBookService/UpdateBookResponse")]
    johnwalsh.com.BookInfo UpdateBook(johnwalsh.com.BookInfo info);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBookServiceChannel : IBookService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BookServiceClient : System.ServiceModel.ClientBase<IBookService>, IBookService
{
    
    public BookServiceClient()
    {
    }
    
    public BookServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public johnwalsh.com.BookInfo GetBook(double price)
    {
        return base.Channel.GetBook(price);
    }
    
    public johnwalsh.com.BookInfo UpdateBook(johnwalsh.com.BookInfo info)
    {
        return base.Channel.UpdateBook(info);
    }
}
