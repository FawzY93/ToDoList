using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.DatabaseManagement;
using ToDoList.Models.ViewModels;

namespace ToDoList.Models.ViewModelBuilders
{
    public class UserGetAllViewModelBuilder : IUserGetAllViewModelBuilder
    {
        private readonly IDataAccessLayer dataAccessLayer;
         
        public UserGetAllViewModelBuilder(IDataAccessLayer dataAccessLayer)
        {
            this.dataAccessLayer = dataAccessLayer;
        }

        public UserGetAllViewModel Build()
        {
            var users = this.dataAccessLayer.getAllUsers();
            return new UserGetAllViewModel
            {
                Users = users
            };
        }
    }
}