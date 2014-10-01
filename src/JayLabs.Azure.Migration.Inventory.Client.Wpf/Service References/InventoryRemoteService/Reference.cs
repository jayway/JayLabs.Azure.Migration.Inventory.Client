﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inventory.Common;

namespace JayLabs.Azure.Migration.Inventory.Client.Wpf.InventoryRemoteService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InventoryRemoteService.InventoryService")]
    public interface InventoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/GetProduct", ReplyAction="http://tempuri.org/InventoryService/GetProductResponse")]
        ProductView GetProduct(System.Guid itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/GetProduct", ReplyAction="http://tempuri.org/InventoryService/GetProductResponse")]
        System.Threading.Tasks.Task<ProductView> GetProductAsync(System.Guid itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/GetProducts", ReplyAction="http://tempuri.org/InventoryService/GetProductsResponse")]
        ProductView[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/GetProducts", ReplyAction="http://tempuri.org/InventoryService/GetProductsResponse")]
        System.Threading.Tasks.Task<ProductView[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/Create", ReplyAction="http://tempuri.org/InventoryService/CreateResponse")]
        void Create(CreateProductCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/Create", ReplyAction="http://tempuri.org/InventoryService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(CreateProductCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/Activate", ReplyAction="http://tempuri.org/InventoryService/ActivateResponse")]
        void Activate(ActiveProductCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/Activate", ReplyAction="http://tempuri.org/InventoryService/ActivateResponse")]
        System.Threading.Tasks.Task ActivateAsync(ActiveProductCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/DeActivate", ReplyAction="http://tempuri.org/InventoryService/DeActivateResponse")]
        void DeActivate(DeActivateCommand command);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InventoryService/DeActivate", ReplyAction="http://tempuri.org/InventoryService/DeActivateResponse")]
        System.Threading.Tasks.Task DeActivateAsync(DeActivateCommand command);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InventoryServiceChannel : JayLabs.Azure.Migration.Inventory.Client.Wpf.InventoryRemoteService.InventoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InventoryServiceClient : System.ServiceModel.ClientBase<JayLabs.Azure.Migration.Inventory.Client.Wpf.InventoryRemoteService.InventoryService>, JayLabs.Azure.Migration.Inventory.Client.Wpf.InventoryRemoteService.InventoryService {
        
        public InventoryServiceClient() {
        }
        
        public InventoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProductView GetProduct(System.Guid itemId) {
            return base.Channel.GetProduct(itemId);
        }
        
        public System.Threading.Tasks.Task<ProductView> GetProductAsync(System.Guid itemId) {
            return base.Channel.GetProductAsync(itemId);
        }
        
        public ProductView[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<ProductView[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public void Create(CreateProductCommand command) {
            base.Channel.Create(command);
        }
        
        public System.Threading.Tasks.Task CreateAsync(CreateProductCommand command) {
            return base.Channel.CreateAsync(command);
        }
        
        public void Activate(ActiveProductCommand command) {
            base.Channel.Activate(command);
        }
        
        public System.Threading.Tasks.Task ActivateAsync(ActiveProductCommand command) {
            return base.Channel.ActivateAsync(command);
        }
        
        public void DeActivate(DeActivateCommand command) {
            base.Channel.DeActivate(command);
        }
        
        public System.Threading.Tasks.Task DeActivateAsync(DeActivateCommand command) {
            return base.Channel.DeActivateAsync(command);
        }
    }
}
