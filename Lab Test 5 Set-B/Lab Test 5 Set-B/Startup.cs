using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_Test_5_Set_B.Startup))]
namespace Lab_Test_5_Set_B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
