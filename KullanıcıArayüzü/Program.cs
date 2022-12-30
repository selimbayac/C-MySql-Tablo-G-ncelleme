using DAO.link_checker;
using DAO.Tools.Connection.MySql;

namespace KullanıcıArayüzü
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ////MysqlConnectionString.GetInstance("localhost", "okul", "root", "@giTo3829");
            //MysqlBaglanti.Connection.Open();
            Application.Run(new LoginPage());
            if (Parameters.ConnectionActive)
                Application.Run(new MainPage());
            Application.Exit();
        }
    }
}