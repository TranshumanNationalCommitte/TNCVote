using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TNCVote.Startup))]
namespace TNCVote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
