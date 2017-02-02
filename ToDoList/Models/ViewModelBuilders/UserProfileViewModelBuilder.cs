using System;
using ToDoList.Models.DataModels;
using ToDoList.Models.ViewModels;

namespace ToDoList.Models.ViewModelBuilders
{
    public class UserProfileViewModelBuilder : IUserProfileViewModelBuilder
    {
        public UserProfileViewModel Build(User user) {
            string name, age,status;
            if (user != null)
            {
                status = "";
                name = user.Name;
                age = user.Age;
            }
            else {
                status = "No users with that ID";
                name = "";
                age = "";
            }
            return new UserProfileViewModel
            {

                Name = name,
                Age = age,
                Status=status
            };    
        }

    }
}