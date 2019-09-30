using System;
using System.Reflection;
using System.Windows.Forms;
using Aggregator.Core;
using Aggregator.GUI.Properties;
using Aggregator.GUI.WinForms;

namespace Aggregator.GUI
{
    
    public static class Program
    {
        public static Form StartupForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
                                                           {

                                                               string assemblyName = args.Name.Substring(0, args.Name.IndexOf(','));
                                                               switch (assemblyName)
                                                               {
                                                                   case "Aggregator.Core":
                                                                       return Assembly.Load(Resources.Aggregator_Core);
                                                                   case "Aggregator.Data":
                                                                       return Assembly.Load(Resources.Aggregator_Data);
                                                                   case "Aggregator.Util":
                                                                       return Assembly.Load(Resources.Aggregator_Util);
                                                                   case "ObjectListView":
                                                                       return Assembly.Load(Resources.ObjectListView);
                                                               }
                                                           return null;
                                                           };

            Application.Run(new MainFormRSS());
        }

        static void OnUnhandledException(object sender,
                                   UnhandledExceptionEventArgs eventArgs)
        {
            Exception exception = (Exception)eventArgs.ExceptionObject;
            string msg = "Error: " + exception.Message;
            if (exception.InnerException != null)
                msg += "\nInner Exceptions:\n" + GetInnerExceptionMessages(exception);

            Console.WriteLine("ERROR ({0}):{1}", exception.GetType().Name, exception.Message);

            MessageBox.Show("Unhandled Exception(s):\n" + msg, "Error in Operation", MessageBoxButtons.OK, MessageBoxIcon.Error,
                              MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly,
                              false);
        }

        public static string GetInnerExceptionMessages(Exception ex)
        {
            Exception inner = ex.InnerException;
            string messages = String.Empty;

            while (inner != null)
            {
                messages += inner.Message;

                if (!messages.EndsWith("."))
                {
                    messages += ".";
                }

                inner = inner.InnerException;
                if (inner != null)
                    messages += "\n";
            }

            return messages;
        }

        #region old code
  //AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
        //{

        //    String resourceName = "AssemblyLoadingAndReflection." +

        //       new AssemblyName(args.Name).Name + ".dll";

        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
        //    {
        //        try
        //        {

        //            Byte[] assemblyData = new Byte[stream.Length];

        //            stream.Read(assemblyData, 0, assemblyData.Length);

        //            return Assembly.Load(assemblyData);

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageShow.ShowException(null, ex, false);
        //            return null;
        //        }
        //    }

        //}; 
        #endregion
      
    }
}
