using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TODO_ListApp.Models;
using TODO_ListApp.ViewModels.Commands;

namespace TODO_ListApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        private string task;
        public string Task { get => task; set => SetProperty(ref task, value); }

        private ObservableCollection<Todo> allTasks = new ObservableCollection<Todo>();

        public ObservableCollection<Todo> AllTasks { get => allTasks; set => SetProperty(ref allTasks, value); }

        private ICommand addTaskCommand;
        public ICommand AddTaskCommand => addTaskCommand = new ActionCommand(AddTask, true);
        private void AddTask()
        {
            AllTasks.Add(new Todo
            {
                Task = task
            });
        }
    }
}
