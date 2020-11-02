using StoreUI.Menus;
using StoreDB;
using Serilog;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("../StoreDB/logs\\TestLogs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Test Log");


            //Calls Welcome Menu
            StoreContext context = new StoreContext();
            IMenu welcomeMenu = new WelcomeMenu(context, new DBRepo(context), new DBRepo(context), new DBRepo(context));
            welcomeMenu.Start();
        }
    }
}
