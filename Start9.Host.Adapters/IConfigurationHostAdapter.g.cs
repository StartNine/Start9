//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Host.Adapters
{
    
    public class IConfigurationHostAdapter
    {
        internal static Start9.Host.Views.IConfiguration ContractToViewAdapter(Start9.Api.Contracts.IConfigurationContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IConfigurationViewToContractHostAdapter))))
            {
                return ((IConfigurationViewToContractHostAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IConfigurationContractToViewHostAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IConfigurationContract ViewToContractAdapter(Start9.Host.Views.IConfiguration view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IConfigurationContractToViewHostAdapter)))
            {
                return ((IConfigurationContractToViewHostAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IConfigurationViewToContractHostAdapter(view);
            }
        }
    }
}
