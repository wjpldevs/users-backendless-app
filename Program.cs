using BackendlessAPI;
using BackendlessAPI.Async;

namespace users_backendless_app
{
    internal static class Program
    {

        static bool isValidLogin => Backendless.UserService.IsValidLogin();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            _ = new APIManager();

            if (isValidLogin)
            {
                Application.Run(new frmModules());
            }
            else 
            {
                Application.Run(new frmLogin());
            }

        }

    }
}