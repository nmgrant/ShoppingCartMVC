using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers {
   public class CheckOutController : Controller {
		private CheckOutModel model = new CheckOutModel();
      //
      // GET: /CheckOut/

      public ActionResult Index() {
			
         return View();
      }
   }
}
