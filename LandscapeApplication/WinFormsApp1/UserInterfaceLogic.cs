namespace WinFormsApp1
{
    internal static class UserInterfaceLogic
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}