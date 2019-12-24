using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_Test_5_Set_D.Startup))]
namespace Lab_Test_5_Set_D
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
