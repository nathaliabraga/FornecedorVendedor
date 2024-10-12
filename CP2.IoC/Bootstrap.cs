using CP2.Application.Services;
using CP2.Data.AppData;
using CP2.Data.Repositories;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CP2.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            // Configurando o DbContext
            services.AddDbContext<ApplicationContext>(x =>
            {
                x.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });

            // Injetando repositórios
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IVendedorRepository, VendedorRepository>();

            // Injetando serviços de aplicação
            services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();
            services.AddTransient<IVendedorApplicationService, VendedorApplicationService>();
        }
    }
}
