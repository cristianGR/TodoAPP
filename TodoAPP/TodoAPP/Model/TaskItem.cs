using System;
using System.Collections.Generic;
using System.Text;

namespace TodoAPP.Model
{
    public class TaskItem
    {
        public string Name { get; set; }
        public string Priority { get; set; }
        public DateTime StartDay { get; set; }
        public bool IsCompleted { get; set; }

    }
}
