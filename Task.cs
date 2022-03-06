using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_WinForms_App
{
    class Task
    {
        #region Fields
        private int id;
        private string name;
        private string description;
        private string status;
        private DateTime dueDate;
        private DateTime createdDate;
        private DateTime modifiedDate;
        #endregion

        #region Properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                return createdDate;
            }
            set
            {
                createdDate = value;
            }
        }

        public DateTime ModifiedDate
        {
            get
            {
                return modifiedDate;
            }
            set
            {
                modifiedDate = value;
            }
        }
        #endregion

        #region Methods
        public void GetTask()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
