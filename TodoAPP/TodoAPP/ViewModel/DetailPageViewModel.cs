using System;
using System.Collections.Generic;
using System.Text;
using TodoAPP.Model;

namespace TodoAPP.ViewModel
{
    class DetailPageViewModel: Notificable
    {
        private TaskItem _itemSelected;
        public DetailPageViewModel(TaskItem item)
        {
            _itemSelected = item;
        }

        public string Nombre
        {
            get { return _itemSelected.Name; }
            set { 
                _itemSelected.Name = value;
                OnPropertyChanged();
            }
        }

        public string Prioridad
        {
            get { return _itemSelected.Priority; }
            set
            {
                _itemSelected.Priority = value;
                OnPropertyChanged();
            }
        }
        public DateTime DiaDeInicio {
            get { return _itemSelected.StartDay; }
            set
            {
                _itemSelected.StartDay = value;
                OnPropertyChanged();
            }
        }
        public bool Completada {
            get { return _itemSelected.IsCompleted; }
            set
            {
                _itemSelected.IsCompleted = value;
                OnPropertyChanged();
            }
        }
    }
}
