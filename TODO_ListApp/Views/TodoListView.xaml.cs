using System.Windows.Controls;
using TODO_ListApp.ViewModels;

namespace TODO_ListApp.Views
{
    /// <summary>
    /// Interaction logic for TodoListView.xaml
    /// </summary>
    public partial class TodoListView : UserControl
    {
        public TodoListView()
        {
            InitializeComponent();
            DataContext = new TodoListViewModel();
        }
    }
}
