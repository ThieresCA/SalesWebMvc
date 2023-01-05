using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;
        private readonly DepartmentServices _departmentServices;

        public SellersController(SellerServices sellerServices, DepartmentServices departmentServices)
        {
            _sellerServices = sellerServices;
            _departmentServices = departmentServices;
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
            //buscando no banco todos os departamentos
            var department = _departmentServices.FindAll();
            //instanciando um SellerFormViewModel passando os departamentos que inserimos na variavel department
            var viewlModel = new SellerFormViewModel { Departments = department };
            //retornando a lista para a view
            return View(viewlModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            //chamando o método Insert da classe SallerServices
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerServices.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            var obj = _sellerServices.FindById(id.Value);
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _sellerServices.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            List<Department> departments = _departmentServices.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, Seller seller)
        {
            if(id == null)
            {
                return NotFound();
            }

            try
            {
            _sellerServices.Update(seller);
            return RedirectToAction("Index");
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch(DbConcurrencyException e)
            {
                return BadRequest();
            }
        }
    }
}
