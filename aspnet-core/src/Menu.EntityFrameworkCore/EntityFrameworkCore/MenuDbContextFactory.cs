using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Menu.Configuration;
using Menu.Web;

namespace Menu.EntityFrameworkCore
{
    public class MenuDbContextFactory : IDesignTimeDbContextFactory<MenuDbContext>
    {
        public MenuDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MenuDbContext>();
            
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MenuDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MenuConsts.ConnectionStringName));

            return new MenuDbContext(builder.Options);
        }
    }
}
