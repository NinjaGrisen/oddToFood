using Microsoft.AspNetCore.Mvc;
using OdeToFood.ViewModels;
using OdeToFood.Services;
using OdeToFood.Entities;

namespace OdeToFood.Controllers
{
    public class HomeController: Controller
    {
        private IResturantData _resturantData;
        private IGreeter _greeter;

        public HomeController(
            IResturantData resturantData,
            IGreeter greeting)
        {
            _resturantData = resturantData;
            _greeter = greeting;
        }
        public IActionResult Index()
        {
            var model = new HomePageViewModel()
            {
                Resturants = _resturantData.GetAll(),
                CurrentGreeting = _greeter.GetGreeting()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _resturantData.Get(id);

            if (model == null)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, ResturantEditViewModel input)
        {
            var resturant = _resturantData.Get(id);
            if (resturant != null && ModelState.IsValid)
            {
                resturant.Name = input.Name;
                resturant.Cuisine = input.Cuisine;
                _resturantData.Commit();

                return RedirectToAction("Details", new { id = resturant.Id });
            }
            return View(resturant);
        }

        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ResturantEditViewModel model)
        {
            if(ModelState.IsValid) { 
                var resturant = new Resturant();
                resturant.Name = model.Name;
                resturant.Cuisine = model.Cuisine;

                _resturantData.Add(resturant);
                _resturantData.Commit();

                return RedirectToAction("details", new { id = resturant.Id });
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var model = _resturantData.Get(id);

            if(model == null)
            {
                return RedirectToAction("Index");
            }

            //can look at route => /id (/2) or query /?id=2
            return View(model);
        } 
    }
}
