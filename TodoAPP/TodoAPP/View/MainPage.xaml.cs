using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TodoAPP.Model;
using TodoAPP.ViewModel;
using TodoAPP.View;

namespace TodoAPP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        public async void DisplayPriorityOptionsEvent(Object sender, EventArgs arg)
        {
            EntryPriority.Text = (string)await DisplayActionSheet("Listado de Prioridades", "Cancelar", null, TaskPriorityEnum.GetTaskPriorities());

        }

        public void AddButtonEvent(object sender, EventArgs args)
        {
            if (EntryTaskName.Text == "" || EntryPriority.Text == "")
            {

                 DisplayAlert("ATENCIÓN", "Debe escribir un nombre para la tarea y seleccionar una prioridad", "Aceptar");
            }
            else
            {
                EntryTaskName.Text = "";
                EntryPriority.Text = "";
                EntryTaskName.Placeholder = "Ingrese nombre de la tarea";
                EntryPriority.Placeholder = "Tipo de prioridad";
            }
        }

        public async void OnItemTappedEvent(object sender, ItemTappedEventArgs _listItem)
        {
            var _listView = sender as ListView;
            TaskItem _itemSelected = (TaskItem)_listItem.Item;
            TaskItemDetailPage _newPage = new TaskItemDetailPage(_itemSelected);
            await Navigation.PushAsync(_newPage);
            _listView.SelectedItem = null;
            
        }
    }
    public  class TaskPriorityEnum
    {
        public enum _taskPriority{
            Baja,
            Media,
            Alta };

        public static string[] GetTaskPriorities()
        {
            return new string[] {
            _taskPriority.Alta.ToString(),
            _taskPriority.Media.ToString(),
            _taskPriority.Baja.ToString()
            };
        }

    }
}
