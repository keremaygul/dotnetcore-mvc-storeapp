using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using StoreApp.Infrastructure.Extensions;

namespace StoreApp.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager _manager;

        private readonly Cart _cart; // IoC Kaydı Var
        public Cart Cart { get; set; }

        public CartModel(IServiceManager manager, Cart cartService)
        {
            _manager = manager;
            Cart = cartService;
        }


        public string ReturnUrl { get; set; } = "/";

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); // cart yoksa yeni oluştur
        }

        public IActionResult OnPost(int ProductID, string returnUrl)
        {
            Product? product = _manager
            .ProductService
            .GetOneProduct(ProductID, false);

            if (product is not null)
            {
                //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); // cart yoksa yeni oluştur
                Cart.AddItem(product, 1);
                //HttpContext.Session.SetJson<Cart>("cart", Cart);
            }
            return RedirectToPage(new { returnUrl = returnUrl }); //return Url
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart(); // cart yoksa yeni oluştur
            Cart.RemoveLine(Cart.Lines.First(c1 => c1.Product.ProductID.Equals(id)).Product);
            //HttpContext.Session.SetJson<Cart>("cart", Cart);
            return Page();
        }


    }
}