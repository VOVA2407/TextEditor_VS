using TextEditor.BL;

namespace TextEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // ApplicationConfiguration.Initialize();

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            FileManager manager = new FileManager();

            MainPresenter presenter = new MainPresenter(form, manager, service);
            Application.Run(form);
        }
    }
}