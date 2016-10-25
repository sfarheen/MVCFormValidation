using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCValidationExample.Startup))]
namespace MVCValidationExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
