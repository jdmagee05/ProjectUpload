using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectUpload.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Upload(String temp)
        {
            return null;
        }
    }
}