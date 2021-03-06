﻿using System.Web.Mvc;
using ToDoList.Models.ViewModelBuilders;
using ToDoList.DatabaseManagement;
using ToDoList.Models.DataModels;

namespace ToDoList.Controllers
{
    public class UserController : Controller
    {
        private readonly IDataAccessLayer dataAccessLayer;
        private readonly IUserProfileViewModelBuilder userProfileViewModelBuilder;
        private readonly IUserGetAllViewModelBuilder userGetAllViewModelBuilder;

        public UserController(IDataAccessLayer dataAccessLayer, IUserProfileViewModelBuilder userProfileViewModelBuilder, IUserGetAllViewModelBuilder userGetAllViewModelBuilder)
        {
            this.dataAccessLayer = dataAccessLayer;
            this.userProfileViewModelBuilder = userProfileViewModelBuilder;
            this.userGetAllViewModelBuilder = userGetAllViewModelBuilder;
        }

        public ActionResult Index ()
        {
            return RedirectToAction("GetAll", "User");
        }

        [HttpPost]
        public ActionResult Preview(string id)
        {
            var user = this.dataAccessLayer.getUser(id);
            return View(this.userProfileViewModelBuilder.Build(user));
            
        }

        [HttpPost]
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
                return RedirectToAction("Preview", "User", new {id = id});

            } else
            {
                return RedirectToAction("Index", "User");
            }
        }

        public ActionResult Add ()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            return View(this.userGetAllViewModelBuilder.Build());
        }
    }
}