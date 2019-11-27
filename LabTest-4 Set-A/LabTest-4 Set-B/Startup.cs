using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabTest_4_Set_B.Startup))]
namespace LabTest_4_Set_B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
