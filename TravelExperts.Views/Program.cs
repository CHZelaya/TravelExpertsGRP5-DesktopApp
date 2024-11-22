namespace TravelExperts.Views
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
            Application.Run(new AdminGUIMain());
          //Change line 14 to launch your GUI if needed. Make note of it on commits. 

        }
    }
}