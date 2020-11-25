using Abp.AspNetCore.Mvc.Authorization;
using CIC_EP.Authorization;
using CIC_EP.Storage;
using Abp.BackgroundJobs;

namespace CIC_EP.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}