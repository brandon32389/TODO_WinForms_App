using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_WinForms_App
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Set up variables necessary.
            DateTime timeStamp = DateTime.Now;

            //Instantiate necessary objects.
            Task task = new Task();
            Main main = new Main();

            //Add fields to the task object
            task.Name = txtTaskName.Text;
            task.Description = txtTaskDesc.Text;
            task.Status = txtStatus.Text;
            task.DueDate = dtpDueDate.Value;
            task.ModifiedDate = timeStamp;
            task.CreatedDate = timeStamp;

            // Add task to the Todo class list.
            task.AddTask(task);
            
            // Hide the add task form.
            this.Hide();
            main.RefreshGrid();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {

        }
    }
}
