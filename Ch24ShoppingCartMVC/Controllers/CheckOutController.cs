using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;
using Ch24ShoppingCartMVC.Models.ViewModels;

namespace Ch24ShoppingCartMVC.Controllers {
   public class CheckoutController : Controller {
		private CheckoutModel model = new CheckoutModel();
      //
      // GET: /CheckOut/

      public ActionResult Index() {
         CheckoutViewModel checkoutModel = model.GetCheckout();
         return View(checkoutModel);
      }
   }
}
