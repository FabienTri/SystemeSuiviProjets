using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using SystemeSuiviProjets.Core.Interfaces;
using SystemeSuiviProjets.Core.Services;
using SystemeSuiviProjets.Infrastructure;
using SystemeSuiviProjets.Infrastructure.Repositories;

namespace SystemeSuiviProjets
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddDbContext < SystèmeSuiviProjetsContext > (options => options.UseSqlServer(@"Server=.;Database=SystèmeSuiviProjetsDB;Trusted_Connection=True;"));
                 services.AddScoped<IClientRepository, ClientRepository>();
                 services.AddScoped<IEmployéRepository, EmployéRepository>();
                 services.AddScoped<IProjetRepository, ProjetRepository>();
                 services.AddScoped<ISessionService, SessionService>();

             
                 services.AddSingleton<FormConnexion>();
                 services.AddSingleton<FormGestionnaire>();
                 services.AddSingleton<FormEmploye>();
                 services.AddSingleton<FormClient>();
             });

            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var forms = services.GetRequiredService<FormConnexion>();
                    Application.Run(forms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}