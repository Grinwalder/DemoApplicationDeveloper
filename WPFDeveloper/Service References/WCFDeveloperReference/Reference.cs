﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFDeveloper.WCFDeveloperReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFDeveloperReference.IWCFDeveloper")]
    public interface IWCFDeveloper {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/DoWork", ReplyAction="http://tempuri.org/IWCFDeveloper/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/DoWork", ReplyAction="http://tempuri.org/IWCFDeveloper/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/GetDevelopers", ReplyAction="http://tempuri.org/IWCFDeveloper/GetDevelopersResponse")]
        LIBDeveloper.Developer[] GetDevelopers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/GetDevelopers", ReplyAction="http://tempuri.org/IWCFDeveloper/GetDevelopersResponse")]
        System.Threading.Tasks.Task<LIBDeveloper.Developer[]> GetDevelopersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/GetProgrammingLanguages", ReplyAction="http://tempuri.org/IWCFDeveloper/GetProgrammingLanguagesResponse")]
        LIBDeveloper.ProgrammingLanguage[] GetProgrammingLanguages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/GetProgrammingLanguages", ReplyAction="http://tempuri.org/IWCFDeveloper/GetProgrammingLanguagesResponse")]
        System.Threading.Tasks.Task<LIBDeveloper.ProgrammingLanguage[]> GetProgrammingLanguagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/SaveDevelopers", ReplyAction="http://tempuri.org/IWCFDeveloper/SaveDevelopersResponse")]
        void SaveDevelopers(LIBDeveloper.Developer[] developers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFDeveloper/SaveDevelopers", ReplyAction="http://tempuri.org/IWCFDeveloper/SaveDevelopersResponse")]
        System.Threading.Tasks.Task SaveDevelopersAsync(LIBDeveloper.Developer[] developers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFDeveloperChannel : WPFDeveloper.WCFDeveloperReference.IWCFDeveloper, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFDeveloperClient : System.ServiceModel.ClientBase<WPFDeveloper.WCFDeveloperReference.IWCFDeveloper>, WPFDeveloper.WCFDeveloperReference.IWCFDeveloper {
        
        public WCFDeveloperClient() {
        }
        
        public WCFDeveloperClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFDeveloperClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFDeveloperClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFDeveloperClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public LIBDeveloper.Developer[] GetDevelopers() {
            return base.Channel.GetDevelopers();
        }
        
        public System.Threading.Tasks.Task<LIBDeveloper.Developer[]> GetDevelopersAsync() {
            return base.Channel.GetDevelopersAsync();
        }
        
        public LIBDeveloper.ProgrammingLanguage[] GetProgrammingLanguages() {
            return base.Channel.GetProgrammingLanguages();
        }
        
        public System.Threading.Tasks.Task<LIBDeveloper.ProgrammingLanguage[]> GetProgrammingLanguagesAsync() {
            return base.Channel.GetProgrammingLanguagesAsync();
        }
        
        public void SaveDevelopers(LIBDeveloper.Developer[] developers) {
            base.Channel.SaveDevelopers(developers);
        }
        
        public System.Threading.Tasks.Task SaveDevelopersAsync(LIBDeveloper.Developer[] developers) {
            return base.Channel.SaveDevelopersAsync(developers);
        }
    }
}