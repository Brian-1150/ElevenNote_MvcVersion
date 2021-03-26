using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNoteWebMVC.Controllers {
    [Authorize]
    public class NoteController : Controller {

        //[C]RUD
        //GET:  CreateNote View
        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model) {
            if (ModelState.IsValid) {

            }
            return View(model);
        }

        //C[R]UD
        // GET: Index - List of notes
        public ActionResult Index() {
            var model = new NoteListItem[0];
            return View(model);
        }
    }


}