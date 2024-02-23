using System;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using TaskManager.Views;
using TaskManager._Repositories;
using TaskManager.Presenters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TaskManager
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

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ITaskHomeForm form = new TaskHomeForm();
            ITaskRepository repository = new TaskRepository(sqlConnectionString);
            new MainPresenter(form, sqlConnectionString); 

            Application.Run((Form)form);
        }
    }
}