using Microsoft.Extensions.DependencyInjection;
using SmayDbEditor.DataAccessLayer;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Repository;
using SmayDbEditor.UserInterface.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var connString = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            var services = new ServiceCollection();
            services.AddTransient<IDbConnection>((x) => new SqlConnection(connString));
            services.AddTransient<IOrderCorrectionRepository, OrderCorrectionRepository>();
            services.AddTransient<IUnlockProductionRepository, UnlockProductionRepository>();
            services.AddTransient<IStatusChangeRepository, StatusChangeRepository>();
            services.AddTransient<IKanbanRemoveRepository, KanbanRemoveRepository>();
            services.AddTransient<IOrderAddressChangeRepository, OrderAddressChangeRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            Application.Run(new LoginForm());
        }
    }
}
