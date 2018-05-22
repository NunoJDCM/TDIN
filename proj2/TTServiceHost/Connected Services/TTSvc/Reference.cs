﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTServHost.TTSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TTSvc.ITTServ")]
    public interface ITTServ {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/HelloWorld", ReplyAction="http://tempuri.org/ITTServ/HelloWorldResponse")]
        string HelloWorld(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/HelloWorld", ReplyAction="http://tempuri.org/ITTServ/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/InitDb", ReplyAction="http://tempuri.org/ITTServ/InitDbResponse")]
        string InitDb(bool overwrite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/InitDb", ReplyAction="http://tempuri.org/ITTServ/InitDbResponse")]
        System.Threading.Tasks.Task<string> InitDbAsync(bool overwrite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AddTicket", ReplyAction="http://tempuri.org/ITTServ/AddTicketResponse")]
        string AddTicket(string title, string description, int author, System.Nullable<int> parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AddTicket", ReplyAction="http://tempuri.org/ITTServ/AddTicketResponse")]
        System.Threading.Tasks.Task<string> AddTicketAsync(string title, string description, int author, System.Nullable<int> parent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AssignTicket", ReplyAction="http://tempuri.org/ITTServ/AssignTicketResponse")]
        string AssignTicket(int id, int assignee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AssignTicket", ReplyAction="http://tempuri.org/ITTServ/AssignTicketResponse")]
        System.Threading.Tasks.Task<string> AssignTicketAsync(int id, int assignee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AnswerTicket", ReplyAction="http://tempuri.org/ITTServ/AnswerTicketResponse")]
        string AnswerTicket(int id, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AnswerTicket", ReplyAction="http://tempuri.org/ITTServ/AnswerTicketResponse")]
        System.Threading.Tasks.Task<string> AnswerTicketAsync(int id, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetTicket", ReplyAction="http://tempuri.org/ITTServ/GetTicketResponse")]
        string GetTicket(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetTicket", ReplyAction="http://tempuri.org/ITTServ/GetTicketResponse")]
        System.Threading.Tasks.Task<string> GetTicketAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetTicketChildren", ReplyAction="http://tempuri.org/ITTServ/GetTicketChildrenResponse")]
        string GetTicketChildren(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetTicketChildren", ReplyAction="http://tempuri.org/ITTServ/GetTicketChildrenResponse")]
        System.Threading.Tasks.Task<string> GetTicketChildrenAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetAuthorTickets", ReplyAction="http://tempuri.org/ITTServ/GetAuthorTicketsResponse")]
        string GetAuthorTickets(int id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetAuthorTickets", ReplyAction="http://tempuri.org/ITTServ/GetAuthorTicketsResponse")]
        System.Threading.Tasks.Task<string> GetAuthorTicketsAsync(int id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetSolverTickets", ReplyAction="http://tempuri.org/ITTServ/GetSolverTicketsResponse")]
        string GetSolverTickets(int id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetSolverTickets", ReplyAction="http://tempuri.org/ITTServ/GetSolverTicketsResponse")]
        System.Threading.Tasks.Task<string> GetSolverTicketsAsync(int id, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUnassignedTickets", ReplyAction="http://tempuri.org/ITTServ/GetUnassignedTicketsResponse")]
        string GetUnassignedTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUnassignedTickets", ReplyAction="http://tempuri.org/ITTServ/GetUnassignedTicketsResponse")]
        System.Threading.Tasks.Task<string> GetUnassignedTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUserByEmail", ReplyAction="http://tempuri.org/ITTServ/GetUserByEmailResponse")]
        string GetUserByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUserByEmail", ReplyAction="http://tempuri.org/ITTServ/GetUserByEmailResponse")]
        System.Threading.Tasks.Task<string> GetUserByEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUserById", ReplyAction="http://tempuri.org/ITTServ/GetUserByIdResponse")]
        string GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/GetUserById", ReplyAction="http://tempuri.org/ITTServ/GetUserByIdResponse")]
        System.Threading.Tasks.Task<string> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AddDepartment", ReplyAction="http://tempuri.org/ITTServ/AddDepartmentResponse")]
        string AddDepartment(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/AddDepartment", ReplyAction="http://tempuri.org/ITTServ/AddDepartmentResponse")]
        System.Threading.Tasks.Task<string> AddDepartmentAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITTServChannel : TTServHost.TTSvc.ITTServ, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TTServClient : System.ServiceModel.ClientBase<TTServHost.TTSvc.ITTServ>, TTServHost.TTSvc.ITTServ {
        
        public TTServClient() {
        }
        
        public TTServClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TTServClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TTServClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TTServClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld(string name) {
            return base.Channel.HelloWorld(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync(string name) {
            return base.Channel.HelloWorldAsync(name);
        }
        
        public string InitDb(bool overwrite) {
            return base.Channel.InitDb(overwrite);
        }
        
        public System.Threading.Tasks.Task<string> InitDbAsync(bool overwrite) {
            return base.Channel.InitDbAsync(overwrite);
        }
        
        public string AddTicket(string title, string description, int author, System.Nullable<int> parent) {
            return base.Channel.AddTicket(title, description, author, parent);
        }
        
        public System.Threading.Tasks.Task<string> AddTicketAsync(string title, string description, int author, System.Nullable<int> parent) {
            return base.Channel.AddTicketAsync(title, description, author, parent);
        }
        
        public string AssignTicket(int id, int assignee) {
            return base.Channel.AssignTicket(id, assignee);
        }
        
        public System.Threading.Tasks.Task<string> AssignTicketAsync(int id, int assignee) {
            return base.Channel.AssignTicketAsync(id, assignee);
        }
        
        public string AnswerTicket(int id, string answer) {
            return base.Channel.AnswerTicket(id, answer);
        }
        
        public System.Threading.Tasks.Task<string> AnswerTicketAsync(int id, string answer) {
            return base.Channel.AnswerTicketAsync(id, answer);
        }
        
        public string GetTicket(int id) {
            return base.Channel.GetTicket(id);
        }
        
        public System.Threading.Tasks.Task<string> GetTicketAsync(int id) {
            return base.Channel.GetTicketAsync(id);
        }
        
        public string GetTicketChildren(int id) {
            return base.Channel.GetTicketChildren(id);
        }
        
        public System.Threading.Tasks.Task<string> GetTicketChildrenAsync(int id) {
            return base.Channel.GetTicketChildrenAsync(id);
        }
        
        public string GetAuthorTickets(int id, string status) {
            return base.Channel.GetAuthorTickets(id, status);
        }
        
        public System.Threading.Tasks.Task<string> GetAuthorTicketsAsync(int id, string status) {
            return base.Channel.GetAuthorTicketsAsync(id, status);
        }
        
        public string GetSolverTickets(int id, string status) {
            return base.Channel.GetSolverTickets(id, status);
        }
        
        public System.Threading.Tasks.Task<string> GetSolverTicketsAsync(int id, string status) {
            return base.Channel.GetSolverTicketsAsync(id, status);
        }
        
        public string GetUnassignedTickets() {
            return base.Channel.GetUnassignedTickets();
        }
        
        public System.Threading.Tasks.Task<string> GetUnassignedTicketsAsync() {
            return base.Channel.GetUnassignedTicketsAsync();
        }
        
        public string GetUserByEmail(string email) {
            return base.Channel.GetUserByEmail(email);
        }
        
        public System.Threading.Tasks.Task<string> GetUserByEmailAsync(string email) {
            return base.Channel.GetUserByEmailAsync(email);
        }
        
        public string GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<string> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public string AddDepartment(string name) {
            return base.Channel.AddDepartment(name);
        }
        
        public System.Threading.Tasks.Task<string> AddDepartmentAsync(string name) {
            return base.Channel.AddDepartmentAsync(name);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TTSvc.IAuthServ")]
    public interface IAuthServ {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/login", ReplyAction="http://tempuri.org/IAuthServ/loginResponse")]
        string login(string email, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/login", ReplyAction="http://tempuri.org/IAuthServ/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string email, string hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/register", ReplyAction="http://tempuri.org/IAuthServ/registerResponse")]
        string register(string name, string email, string hash, string salt, int department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/register", ReplyAction="http://tempuri.org/IAuthServ/registerResponse")]
        System.Threading.Tasks.Task<string> registerAsync(string name, string email, string hash, string salt, int department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/logout", ReplyAction="http://tempuri.org/IAuthServ/logoutResponse")]
        string logout(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/logout", ReplyAction="http://tempuri.org/IAuthServ/logoutResponse")]
        System.Threading.Tasks.Task<string> logoutAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/getSalt", ReplyAction="http://tempuri.org/IAuthServ/getSaltResponse")]
        string getSalt(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthServ/getSalt", ReplyAction="http://tempuri.org/IAuthServ/getSaltResponse")]
        System.Threading.Tasks.Task<string> getSaltAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServChannel : TTServHost.TTSvc.IAuthServ, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServClient : System.ServiceModel.ClientBase<TTServHost.TTSvc.IAuthServ>, TTServHost.TTSvc.IAuthServ {
        
        public AuthServClient() {
        }
        
        public AuthServClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string login(string email, string hash) {
            return base.Channel.login(email, hash);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string email, string hash) {
            return base.Channel.loginAsync(email, hash);
        }
        
        public string register(string name, string email, string hash, string salt, int department) {
            return base.Channel.register(name, email, hash, salt, department);
        }
        
        public System.Threading.Tasks.Task<string> registerAsync(string name, string email, string hash, string salt, int department) {
            return base.Channel.registerAsync(name, email, hash, salt, department);
        }
        
        public string logout(string token) {
            return base.Channel.logout(token);
        }
        
        public System.Threading.Tasks.Task<string> logoutAsync(string token) {
            return base.Channel.logoutAsync(token);
        }
        
        public string getSalt(string email) {
            return base.Channel.getSalt(email);
        }
        
        public System.Threading.Tasks.Task<string> getSaltAsync(string email) {
            return base.Channel.getSaltAsync(email);
        }
    }
}
