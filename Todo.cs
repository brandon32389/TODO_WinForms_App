using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_WinForms_App
{
    public class Todo
    {
        private List<Task> tasks;
        //DB connection?f

        public List<Task> Tasks
        {
            get
            {
                if (tasks == null)
                {
                    tasks = new List<Task>();
                }

                return tasks;

            }
        }

        public Todo()
        {
            GetTasks();
        }

        public void GetTasks()
        {
            string path = "Tasks.csv";

            using (StreamReader sr = File.OpenText(path))
            {
                String line = "";
                String[] taskArray;
                Task task;

                while ((line = sr.ReadLine()) != null)
                {
                    taskArray = line.Split(',');

                    if (taskArray.Length == 6)
                    {
                        task = new Task();

                        task.Name = taskArray[0];
                        task.Description = taskArray[1];
                        task.Status = taskArray[2];
                        task.DueDate = DateTime.Parse(taskArray[3]);
                        task.CreatedDate = DateTime.Parse(taskArray[4]);
                        task.ModifiedDate = DateTime.Parse(taskArray[5]);

                        Tasks.Add(task);
                    }
                    else
                    {
                        throw new Exception("Unexpected number of columns!");
                    }
                }
              
            }
        }

        public void ModifyTask()
        {
            throw new NotImplementedException();
        }

        public void DeleteTask()
        {
            throw new NotImplementedException();
        }
    }
}
