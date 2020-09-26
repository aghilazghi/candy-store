using CandyStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyStore.ViewModels;

namespace CandyStore.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel
            {
                Candies = _candyRepository.GetAllCandies,
                CurrentCategory = "Best Sellers"
            };

            return View(candyListViewModel);
        }
    }
}
