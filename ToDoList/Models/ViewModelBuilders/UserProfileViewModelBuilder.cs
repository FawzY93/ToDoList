using System;
using ToDoList.Models.DataModels;
using ToDoList.Models.ViewModels;

namespace ToDoList.Models.ViewModelBuilders
{
    public class UserProfileViewModelBuilder : IUserProfileViewModelBuilder
    {
        public UserProfileViewModel Build(User user) {
            return new UserProfileViewModel
            {
                Name = user.Name,
                Age = user.Age
            };    
        }

    }
}