using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Menu.Authorization.Roles;
using Menu.Authorization.Users;
using Menu.MultiTenancy;

namespace Menu.EntityFrameworkCore
{
    public class MenuDbContext : AbpZeroDbContext<Tenant, Role, User, MenuDbContext>
    {
        
        public MenuDbContext(DbContextOptions<MenuDbContext> options)
            : base(options)
        {
        }
    }
}
