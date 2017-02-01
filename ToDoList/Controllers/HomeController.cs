using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models.ViewModels;
using ToDoList.Models.ViewModelBuilders;
using ToDoList.DatabaseManagement;
using ToDoList.Models.DataModels;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataAccessLayer dataAccessLayer;
        private readonly IHomeGetViewModelBuilder homeGetViewModelBuilder;

        public HomeController(IDataAccessLayer dataAccessLayer, IHomeGetViewModelBuilder homeGetViewModelBuilder)
        {
            this.dataAccessLayer = dataAccessLayer;
            this.homeGetViewModelBuilder = homeGetViewModelBuilder;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(string id)
        {
            var user = this.dataAccessLayer.getUser(id);
            return View(this.homeGetViewModelBuilder.Build(user));
        }

        public ActionResult Add(string id, string name, string age)
        {
            var user = new User
            {
                Age = age,
                Name = name,
                EmployeeId = id
            };
            if (this.dataAccessLayer.AddUser(user))
            {
                return RedirectToAction("Get", "Home", new {id = id});
            } else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}