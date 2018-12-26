using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            return View(indexViewModel);
        }

        public IActionResult Error()
        {

            return View();
        }

        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "There is no value to asses the square's attributes. Please return to the Home page.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {

                Squareshape qbert = new Squareshape("qbert", resultViewModel.sidelength);

                resultViewModel.Area = qbert.Area(resultViewModel.sidelength);
                resultViewModel.Perimeter = qbert.Perimeter(resultViewModel.sidelength);

                return View(resultViewModel);


            }


            return Redirect("/Home/Error");

        }

    }



}
