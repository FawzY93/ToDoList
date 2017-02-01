using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models.DataModels;

namespace ToDoList.DatabaseManagement
{
    public interface IDataAccessLayer
    {
        User getUser(string employeeId);

        bool AddUser(User user);
    }
}
