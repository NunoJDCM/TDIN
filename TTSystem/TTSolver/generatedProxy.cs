﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ITTServ")]
public interface ITTServ
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/HelloWorld", ReplyAction="http://tempuri.org/ITTServ/HelloWorldResponse")]
    string HelloWorld(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITTServ/HelloWorld", ReplyAction="http://tempuri.org/ITTServ/HelloWorldResponse")]
    System.Threading.Tasks.Task<string> HelloWorldAsync(string name);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ITTServChannel : ITTServ, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TTServClient : System.ServiceModel.ClientBase<ITTServ>, ITTServ
{
    
    public TTServClient()
    {
    }
    
    public TTServClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public TTServClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TTServClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TTServClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string HelloWorld(string name)
    {
        return base.Channel.HelloWorld(name);
    }
    
    public System.Threading.Tasks.Task<string> HelloWorldAsync(string name)
    {
        return base.Channel.HelloWorldAsync(name);
    }
}