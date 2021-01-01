using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shopping_basket.Startup))]
namespace shopping_basket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
