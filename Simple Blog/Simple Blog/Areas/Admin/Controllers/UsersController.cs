using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Blog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult index()
        {
            return Content("Index121213");
        }

        public ActionResult list()
        {
            return Content("Listeee");
        }

        public ActionResult control(int id=0)
        {
            return Content("kontrolum ="+id);
        }
    }
}