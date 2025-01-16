using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToDo
{
    public class ToDo
    {
        public static int ObjectCounter = 0;
        public int id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public ToDo(String description, DateTime date, bool doneState)
        {
            ObjectCounter++;
            id = ObjectCounter;
            TaskDescription = description;
            DueDate = date; 
            IsDone = doneState;
        }
    }
}
