﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToDo
{
    public class ToDo
    {
        public static int ObjectCounter = 0;
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

        public string GetStatus()
        {
            string status = "";
           
            if (!IsDone)
            {
                status = "Status: Incomplete";
               
            }
          
            else
            {
                status = "status: Complete";
            }
            return status;
        }
        public ToDo(String description, DateTime date, bool doneState = false)
        {
            ObjectCounter++;
            Id = ObjectCounter;
            TaskDescription = description;
            DueDate = date; 
            IsDone = doneState;
        }

        public override string? ToString()
        {
            return $"{Id} - {DueDate} - {TaskDescription} - { GetStatus() }";
        }
    }
}
