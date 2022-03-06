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
    public partial class Main : Form
    {   
        AddTask addTask = new AddTask();
        public Todo todo = new Todo();
        public Main()
        {
            InitializeComponent();
            
        }
        private void Main_Refresh(object sender, EventArgs e)
        {
            todo.GetTasks();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = todo.Tasks;
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            addTask.Show();
        }
        public void RefreshGrid()
        {
            dgvMain.DataSource = null;
            todo.GetTasks();
            dgvMain.Update();
            dgvMain.Refresh();
            dgvMain.DataSource = todo.Tasks;
        }

    }
}
