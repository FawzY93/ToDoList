using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models.DataModels;
using ToDoList.Models.ViewModels;

namespace ToDoList.Models.ViewModelBuilders
{
    public interface IHomeGetViewModelBuilder
    {
        HomeGetViewModel Build(User user);
    }
}
