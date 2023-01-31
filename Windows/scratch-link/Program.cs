using System;
using System.IO;
using System.Windows.Forms;

namespace scratch_link
{
    static class Program
    {
		public static TextWriter log;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void LogLine(String a_line)
        {
            log.WriteLine(a_line);
            log.Flush();
        }

        static void Main()
        {
			String logFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scratch_link";
			Directory.CreateDirectory(logFolder);
			log = File.CreateText(logFolder + "\\log.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var appContext = new App();
            Application.Run(appContext);
        }
    }
}
