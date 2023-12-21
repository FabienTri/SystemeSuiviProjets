using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using SystemeSuiviProjets.Core;
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
                    //create a client in db
                    string nomConnexon = "admin";
                    string motDePasse = "admin";
                    string adresse = "123 rue de la rue";
                    string téléphone = "123456789";
                    string nom = "admin";
                    string prénom = "admin";
                    DateOnly dateEmbauche = DateOnly.FromDateTime(DateTime.Now);

                    var professionnel = new Professionnel(nomConnexon, motDePasse, nom, prénom, adresse, téléphone, dateEmbauche);

                    SystèmeSuiviProjetsContext systèmeSuiviProjetsContext = new SystèmeSuiviProjetsContext();
                    systèmeSuiviProjetsContext.Professionnels.Add(professionnel);
                    systèmeSuiviProjetsContext.SaveChanges();


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