using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WarehouseMVCCore.Models;
using WarehouseMVCCore.Models.Repositories;

namespace WarehouseMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWarehouseRepo repo;

        public HomeController(IWarehouseRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            //var repo = new WarehouseRepo();
            var model = repo.GetAll();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(WarehouseModel warehouseModel)
        {
            if (ModelState.IsValid)
            {
                repo.Add(warehouseModel);
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseModel);
        }
        public IActionResult Update(int id)
        {
            var model = repo.GetAll().SingleOrDefault(w => w.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(WarehouseModel warehouseModel)
        {
            if (ModelState.IsValid)
            {
                repo.Update(warehouseModel);
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
            return View(warehouseModel);
        }
        public IActionResult Delete(int? id)
        {
            var model = repo.GetAll().SingleOrDefault(w => w.Id == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Błędne id");                
            }
            repo.Delete(id);            
            return RedirectToAction(nameof(Index));           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
