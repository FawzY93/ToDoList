using System;
using ToDoList.Models.DataModels;
using ToDoList.Models.ViewModels;

namespace ToDoList.Models.ViewModelBuilders
{
    public class HomeGetViewModelBuilder : IHomeGetViewModelBuilder
    {
        public HomeGetViewModel Build(User user) {
            return new HomeGetViewModel
            {
                Name = user.Name,
                Age = user.Age
            };    
        }

    }
}