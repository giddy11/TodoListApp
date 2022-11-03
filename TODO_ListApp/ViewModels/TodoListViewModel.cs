using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_ListApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        private string myVar1;

        public string MyProperty1
        {
            get { return myVar; }
            set { myVar = value; OnPropertyChanged(); }
        }

        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; OnPropertyChanged(); }
        }


    }
}
