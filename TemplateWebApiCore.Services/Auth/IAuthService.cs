using System.Threading.Tasks;
using TemplateWebApiCore.Domain.Business;

namespace TemplateWebApiCore.Services.Auth
{
    public interface IAuthService
    {
        public Task<UserInfoModel> Login(UserModel user);
        public Task<bool> Registration(UserModel user);
    }
}
