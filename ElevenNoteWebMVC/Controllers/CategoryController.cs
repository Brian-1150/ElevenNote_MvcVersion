using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNoteWebMVC.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private CategoryService CategoryServiceInstance()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CategoryService(userId);
            return service;
        }

        //[C]RUD
        //GET:  CreateNote View
        public ActionResult Create()
        {
            return View();
        }


        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}