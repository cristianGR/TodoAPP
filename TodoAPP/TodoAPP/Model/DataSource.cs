using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace TodoAPP.Model
{
    class DataSource
    {
        private ObservableCollection<TaskItem> _items;
        public DataSource()
        {
            _items = new ObservableCollection<TaskItem>();
        }

        public ObservableCollection<TaskItem> Items
        {
            get { return _items; }
        }

        public void AddTaskItem(string _taskItemName, string TaskPriority)
        {
            _items.Add(new TaskItem {
                Name = _taskItemName,
                Priority = TaskPriority,
                StartDay = DateTime.Now,
                IsCompleted = false,
            }); 
        }
        public bool RemoveTaskItem(TaskItem _ItemToRemove)
        {
           return _items.Remove(_ItemToRemove);
        }

    }
}
