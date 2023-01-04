using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        //chamada do controlador
        public IActionResult Index()
        {
            //controlador acessa o model pegou os dados e armazenou na variavel
            var list = _sellerServices.FindAll();
            //passando o list como parametro para que o view retorne um IActionResult contendo a Lista
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            //chamando o método Insert da classe SallerServices
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
