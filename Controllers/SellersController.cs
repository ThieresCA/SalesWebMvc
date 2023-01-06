﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using System.Collections.Generic;
using System.Diagnostics;

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
            //validação feita para que caso o JS seja desativado no navegador não ocorra quebra de confiabilidade nos dados
            if (!ModelState.IsValid)
            {
                return View(seller);
            }
            //chamando o método Insert da classe SallerServices
            _sellerServices.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id não fornecido" });
            }
            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Objeto não encontrado" });
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
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "Id nulo ou não fornecido" });
            }

            var obj = _sellerServices.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { Message = "não foi encontrado um Id" });
            }

            List<Department> departments = _departmentServices.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            //validação feita para que caso o JS seja desativado no navegador não ocorra quebra de confiabilidade nos dados
            if (!ModelState.IsValid)
            {
                return View(seller);
            }

            if (!ModelState.IsValid)
            {
                var departments = _departmentServices.FindAll();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(viewModel);
            }
            if (id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde a um vendedor" });
            }
            try
            {
                _sellerServices.Update(seller);
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


