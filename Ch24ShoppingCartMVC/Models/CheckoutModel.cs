using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models.ViewModels;

namespace Ch24ShoppingCartMVC.Models {
	public class CheckoutModel {

      private List<ProductViewModel> GetCartFromDataStore() {
         List<ProductViewModel> cart;
         object objCart = HttpContext.Current.Session["cart"];
         //Convert objCart to List<ProductViewModel>
         cart = (List<ProductViewModel>)objCart;
         if (cart == null) {   //Create the object cart
            objCart = new List<ProductViewModel>();
            //Assign cart to the Session object cart
            cart = (List<ProductViewModel>)objCart;
         }
         return cart;
      }

      public CheckoutViewModel GetCheckout() {
         CheckoutViewModel model = new CheckoutViewModel();
         //Call the method GetCartFromDataStore
         model.Cart = GetCartFromDataStore();
         return model;
      }
   }
}