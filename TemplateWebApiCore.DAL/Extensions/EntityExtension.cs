using Microsoft.EntityFrameworkCore;
using System.Linq;
using TemplateWebApiCore.DAL.Entity;

namespace TemplateWebApiCore.DAL.Extensions
{
    public static class EntityExtension
    {
        public static IQueryable<User> AddRoles(this IQueryable<User> query)
        {
            return query.Include(x => x.Roles);
        }
    }
}
