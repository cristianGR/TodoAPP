using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TodoAPP.Model;
using Xamarin.Forms;


namespace TodoAPP.ViewModel
{
    class MainPageViewModel : Notificable
    {
        private DataSource _dataSourceOfItemsTask;
        private Command _addTaskItem;
        private string _nombre;
        private string _priority;

        public MainPageViewModel()
        {
            _dataSourceOfItemsTask = new DataSource();
            _addTaskItem = new Command(AddEventTaskItem);
        }

        public ObservableCollection<TaskItem> Items
        {
            get { return _dataSourceOfItemsTask.Items; }
        }

        public void AddEventTaskItem()
        {
            if (!string.IsNullOrWhiteSpace(Nombre) && !string.IsNullOrWhiteSpace(Prioridad))
                _dataSourceOfItemsTask.AddTaskItem(Nombre, Prioridad);
        }

        public string Nombre
        {
            set { 
                _nombre = value;
                OnPropertyChanged();
                OnPropertyChanged("ErrorEnNombre");
            }
            get { return _nombre; }
        }

        public string Prioridad
        {
            set { 
                _priority = value;
                OnPropertyChanged();
            }
            get { return _priority; }
        }

        public Command Agregar
        {
            get { return _addTaskItem; }
            set {_addTaskItem = value; }
        }

    }
}
