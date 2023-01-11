using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordServices _salesRecordServices;
        public SalesRecordsController(SalesRecordServices salesRecordServices)
        {
            _salesRecordServices = salesRecordServices;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _salesRecordServices.GetAllSellersAsync();
            var viewModel = new SellerlistViewModel { Sellers = result };
            return View(viewModel);
        }
        public async Task<IActionResult> SimpleSearch(DateTime minDate, DateTime maxDate)
        {
            var result = await _salesRecordServices.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _salesRecordServices.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> SearchById(int id)
        {
            var result = await _salesRecordServices.FindBySellerId(id);
            return View(result);
        }
    }
}
