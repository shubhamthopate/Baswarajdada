using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using CIC_EP.Authorization.Users;
using CIC_EP.MultiTenancy;

namespace CIC_EP.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}