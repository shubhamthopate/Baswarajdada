namespace CIC_EP.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}