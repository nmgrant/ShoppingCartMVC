using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch24ShoppingCartMVC.Models.ViewModels {
   public class CheckoutViewModel {
      public List<ProductViewModel> Cart { get; set; }
      public double TAX_RATE {
         get {
            return 0.08;
         }
      }
      public double Total {
         get {
            double sum = 0;
            foreach (var item in Cart) {
               sum += (double)(item.UnitPrice) * (item.Quantity);
            }
            return Math.Round(sum, 2);
         }
      }
      public List<string> PaymentOptions {
         get {
            List<string> options = new List<string>();
            options.Add("Visa");
            options.Add("MasterCard");
            options.Add("PayPal");
            return options;
         }
      }
   }
}