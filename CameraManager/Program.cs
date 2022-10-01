namespace CameraManager
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
           // c
            var Settings = new IniFile("data.ini");
            var firstrun = Settings.Read("RAN");
            if (firstrun == "")
            {
                //var formsetup = new FormSetup();
                //formsetup.ShowDialog();
                Application.Run(new FormSetup());
            }
            else
            {
                Application.Run(new FormHome());
            }
        }
    }
}