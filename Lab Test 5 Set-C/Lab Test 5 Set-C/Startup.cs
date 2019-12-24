using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_Test_5_Set_C.Startup))]
namespace Lab_Test_5_Set_C
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
