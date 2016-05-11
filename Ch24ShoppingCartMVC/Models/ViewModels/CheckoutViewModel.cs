using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ch24ShoppingCartMVC.Models.ViewModels {
	public class CheckOutViewModel {
		public List<ProductViewModel> Cart { get; set; }
		public const double TAX_RATE = 0.08;
		public List<string> PaymentOptions {
			get {
				List<string> options = new List<string>;
				options.Add("Visa");
				options.Add("MasterCard");
				options.Add("PayPal");
				return options;
			}
		}
	}
}