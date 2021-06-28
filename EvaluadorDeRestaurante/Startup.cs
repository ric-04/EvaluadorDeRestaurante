using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvaluadorDeRestaurante.Startup))]
namespace EvaluadorDeRestaurante
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
