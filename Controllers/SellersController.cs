using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index()
        {
            //controlador acessa o model pegou os dados e armazenou na variavel
            var list = await _sellerServices.FindAllAsync();
            //passando o list como parametro para que o view retorne um IActionResult contendo a Lista
            return View(list);
        }

        public async Task<IActionResult> Inactives()
        {
            //controlador acessa o model pegou os dados e armazenou na variavel
            var list = await _sellerServices.FindAllAsync();
            //passando o list como parametro para que o view retorne um IActionResult contendo a Lista
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            //buscando no banco todos os departamentos
            var department = await _departmentServices.FindAllAsync();
            //instanciando um SellerFormViewModel passando os departamentos que inserimos na variavel department
            var viewlModel = new SellerFormViewModel { Departments = department };
            //retornando a lista para a view
            return View(viewlModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            //validação feita para que caso o JS seja desativado no navegador não ocorra quebra de confiabilidade nos dados
            if (!ModelState.IsValid)
            {
                var department = await _departmentServices.FindAllAsync();
                var viewModel = new SellerFormViewModel
                {
                    Departments = department,
                    Seller = seller
                };
                return View(viewModel);
            }
            //chamando o método Insert da classe SallerServices
            await _sellerServices.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id não fornecido" });
            }
            var obj = await _sellerServices.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Objeto não encontrado" });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //pegando o id do objeto
            var seller = await _sellerServices.FindByIdAsync(id);
            //alterando a propriedade Active para falso, ou seja Inativo
            if (!seller.Active)
            {
                seller.Active = true;
            }
            else
            {
                seller.Active = false;
            }
            //fazendo o update
            await _sellerServices.UpdateAsync(seller);
            //retornando para o index
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _sellerServices.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id nulo ou não fornecido" });
            }

            var obj = await _sellerServices.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "não foi encontrado um Id" });
            }

            List<Department> departments = await _departmentServices.FindAllAsync();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller)
        {
            //validação feita para que caso o JS seja desativado no navegador não ocorra quebra de confiabilidade nos dados
            if (!ModelState.IsValid)
            {
                var department = await _departmentServices.FindAllAsync();
                var viewModel = new SellerFormViewModel
                {
                    Departments = department,
                    Seller = seller
                };
                return View(viewModel);
            }

            if (!ModelState.IsValid)
            {
                var departments = await _departmentServices.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde a um vendedor" });
            }
            try
            {
                await _sellerServices.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}


