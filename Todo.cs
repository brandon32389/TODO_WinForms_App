using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_WinForms_App
{
    class Todo
    {
        private List<Task> tasks;

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

        public void AddTask()
        {
            throw new NotImplementedException();
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
