using System.Threading.Tasks;
using Menu.Models.TokenAuth;
using Menu.Web.Controllers;
using Shouldly;
using Xunit;

namespace Menu.Web.Tests.Controllers
{
    public class HomeController_Tests: MenuWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}