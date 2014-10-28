using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitTFSTest.Startup))]
namespace GitTFSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
