using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAPP.Model;
using TodoAPP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoAPP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskItemDetailPage : ContentPage
    { 
        public TaskItemDetailPage(TaskItem item)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(item);
        }
    }
}