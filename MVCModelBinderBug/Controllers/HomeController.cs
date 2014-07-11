
using MVCModelBinderBug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModelBinderBug.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            HomeViewModel hvm = new HomeViewModel();
            hvm.MoreProperty = 1;
            return View(hvm);
        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * 
         * Uncomment method below to reproduce bug
         * This bug's key point is parameter name. 
         * As you notice it is same (case insentive) with one of properties name in HomeViewModel.
         * Of course it doesn't relevant with being "Model", every thing cause same bug if they match.
         * * * * * * * * * * * * * * * * * * * * * * * * * * 
         */

        /*
        [HttpPost]
        public ActionResult FormPost(HomeViewModel model) {
            FormPostViewModel fvm = new FormPostViewModel();
            fvm.Name = model.Model.Name;
            fvm.SomeOtherProperty = model.SomeOtherProperty;

            return View(fvm);
        }
         */

        // Don't forget to comment action below, when you uncomment action above ;)
        [HttpPost]
        public ActionResult FormPost(HomeViewModel entity) {
            FormPostViewModel fvm = new FormPostViewModel();
            fvm.Name = entity.Model.Name;
            fvm.SomeOtherProperty = entity.SomeOtherProperty;

            return View(fvm);
        }
    }
}