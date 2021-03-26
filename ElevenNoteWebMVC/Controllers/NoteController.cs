using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNoteWebMVC.Controllers {
    [Authorize]
    public class NoteController : Controller {
        private NoteService CreateNoteService() {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userId);
            return service;
        }

        //[C]RUD
        //GET:  CreateNote View
        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model) {
            if (!ModelState.IsValid)
                return View(model);

            var service = CreateNoteService();
            if (service.CreateNote(model)) {
                TempData["SaveResult"] = "Your note was successfully created!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Note could not be created.");

            return View(model);
        }



        //C[R]UD
        // GET: Index - List of notes
        public ActionResult Index() {
            var service = CreateNoteService();
            //var model = new NoteListItem[0];
            var model = service.GetNotes();
            return View(model);
        }
    }


}