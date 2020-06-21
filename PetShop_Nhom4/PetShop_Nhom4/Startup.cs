using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetShop_Nhom4.Startup))]
namespace PetShop_Nhom4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
