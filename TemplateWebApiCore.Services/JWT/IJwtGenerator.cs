using TemplateWebApiCore.DAL.Entity;

namespace TemplateWebApiCore.Services.JWT
{
    public interface IJwtGenerator
    {
        string CreateToken(User user);
    }
}
