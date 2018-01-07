using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBRefactoringWEB.Startup))]
namespace DBRefactoringWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
