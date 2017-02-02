using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models.DataModels;

namespace ToDoList.Models.ViewModels
{
    public class UserGetAllViewModel
    {
        public List<User> Users { get; set; } 
    }
}