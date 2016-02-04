using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BowlingGame_TDD.Startup))]
namespace BowlingGame_TDD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
