using _272_HW4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _272_HW4.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            List<Food> food = new List<Food>();
            Perishable food1 = new Perishable(new DateTime(2022, 10, 03, 0, 0, 0), "Chocolate", "Sugar", true, false);
            food.Add(food1);
            Perishable food2 = new Perishable(new DateTime(2023, 01, 15, 0, 0, 0), "FruitCake", "Flour", true, true);
            food.Add(food2);
            Canned food3 = new Canned(new DateTime(2025, 05, 10, 0, 0, 0), "Baked Beans", "Beans", 3, "Large");
            food.Add(food3);
            Dry food4 = new Dry(new DateTime(2023, 11, 12, 0, 0, 0), "Cocoa Pops", "Sugar", "Malt", true);
            food.Add(food4);
            Perishable food5 = new Perishable(new DateTime(2022, 09, 9, 0, 0 ,0) , "Pork Ribs", "Pork", false, false);
            food.Add(food5);
            Canned food6 = new Canned(new DateTime(2024, 02, 03, 0, 0, 0), "Tuna", "Tuna", 20, "Large");
            food.Add(food6);
            Dry food7 = new Dry(new DateTime(2023, 06, 23, 0, 0, 0), "Spagetti", "Wheat", "Corn", false);
            food.Add(food7);
            Canned food8 = new Canned(new DateTime(2023, 12, 30, 0, 0, 0), "Bully Beef", "Beef", 2, "Small");
            food.Add(food8);
            Dry food9 = new Dry(new DateTime(2022, 11, 14, 0, 0, 0), "All Bran", "Bran", "Barley and Wheat", true);
            food.Add(food9);
            Perishable food10 = new Perishable(new DateTime(2022, 09, 23, 0, 0, 0), "Slap Chips", "Potato", false, true);
            food.Add(food10);
            return View(food);
        }
    }
}