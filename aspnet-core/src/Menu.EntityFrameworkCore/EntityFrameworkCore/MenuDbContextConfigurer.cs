using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Menu.EntityFrameworkCore
{
    public static class MenuDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MenuDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MenuDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
