using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotvvmSample.ViewModels
{
    public class DefaultViewModel : DotvvmViewModelBase
    {
        // a list of tasks
        public List<TaskData> Tasks { get; set; } = new List<TaskData>();

        // text of a new task
        public string NewTaskText { get; set; }

        public void AddNewTask()
        {
            Tasks.Add(new TaskData()
            {
                Text = NewTaskText
            });
            NewTaskText = string.Empty;
        }

        public void CompleteTask(TaskData task)
        {
            task.CompletedDate = DateTime.Now;
        }
    }

    public class TaskData
    {
        public string Text { get; set; }

        public DateTime? CompletedDate { get; set; }
    }
}
