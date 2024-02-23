using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManager._Repositories;
using TaskManager.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TaskManager.Presenters
{
    public class MainPresenter
    {

        private ITaskHomeForm homeForm;
        private readonly string sqlConnectionString;
        public MainPresenter(ITaskHomeForm homeForm, string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
            this.homeForm = homeForm;
            ITaskRepository repository = new TaskRepository(sqlConnectionString);
            new TaskHomePresenter(repository, homeForm);
        }
        
    }
}
