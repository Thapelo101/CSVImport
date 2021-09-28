using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CSVImport.Controllers
{
    public class RedirectController
    {
        public object Session { get; private set; }

        public ActionResult Index()
        {
            if (Session["Username"] == null)
            {
                return view();
            }
            else
            {
                return RedirectToAction("LoginView");
            }
        }

        private ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        private ActionResult view()
        {
            throw new NotImplementedException();
        }
    }
}
