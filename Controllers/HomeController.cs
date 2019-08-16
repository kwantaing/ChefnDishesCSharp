using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefnDishes.Models;
using System.Data.Entity;

namespace ChefnDishes.Controllers
{
    public class HomeController : Controller
    {
        public ChefnDishContext dbContext;
        public HomeController(ChefnDishContext context){
            dbContext = context;
        }
        public IActionResult Index()
        {
            var results = dbContext.Chefs.ToList();
            return View(results);
        }
        public IActionResult newChef(){
            return View();
        }
        [HttpPost("Home/addChef")]
        public IActionResult addChef(Chef newChef){
            if(ModelState.IsValid){
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View("newChef");
            }
        }
        public IActionResult newDish(){
            ViewBag.Chefs = dbContext.Chefs.ToList();
            return View();
        }
        
        public IActionResult addDish(Dish newDish, int chef_id_for_dish){
            newDish.chef = dbContext.Chefs.FirstOrDefault(c => c.user_id == chef_id_for_dish);
            dbContext.Dishes.Add(newDish);
            dbContext.SaveChanges();
            var chef = dbContext.Chefs.FirstOrDefault(c => c.user_id == chef_id_for_dish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("chefs/{chef_id}")]
        public IActionResult chefDetail(int chef_id){
            var chefWithDishes = dbContext.Chefs.Include(c => c.Dishes).FirstOrDefault(c => c.user_id == chef_id);
            return View("Detail",chefWithDishes);
        }
        public IActionResult showall(){
            List<Chef> results = dbContext.Chefs.ToList();
            return View("Index",results);
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
