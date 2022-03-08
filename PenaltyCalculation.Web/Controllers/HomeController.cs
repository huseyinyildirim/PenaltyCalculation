using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PenaltyCalculation.Business.Dtos;
using PenaltyCalculation.Business.Services;
using PenaltyCalculation.Web.Models;

namespace PenaltyCalculation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ICountryService _countryService;
        private readonly ITransactionService _transactionService;

        public HomeController(ILogger<HomeController> logger, ICountryService countryService, ITransactionService transactionService)
        {
            _logger = logger;

            _countryService = countryService;
            _transactionService = transactionService;
        }

        public IActionResult Index()
        {
            var indexViewModel = new IndexViewModel();

            var result = _countryService.GetCountries();
            indexViewModel.CountrySelectList = GetCountrySelectList(result);

            return View(indexViewModel);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            var result = _transactionService.PenaltyCalculate(model.PurchaseDate, model.DeliveryDate, model.CountryId);

            var countries = _countryService.GetCountries();

            var indexViewModel = new IndexViewModel
            {
                PenaltyCalculate = result,
                CountryId = result.CountryId,
                CountrySelectList = GetCountrySelectList(countries),
            };

            return View(indexViewModel);
        }

        private static List<SelectListItem> GetCountrySelectList(IEnumerable<CountryDto> data)
        {
            var selectList = new List<SelectListItem>();

            if (data != null)
            {
                foreach (var item in data)
                {
                    selectList.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString(), Selected = false });
                }
            }

            return selectList;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
