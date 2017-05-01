using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context)  //Инжектируем data context в контроллер
        {
            _context = context;
        }

        public IActionResult GetObject(int id)  //Читаем данные
        {
            var data = _context.Goods.FirstOrDefault(x => x.Id == id);
            return Json(data);
        }

        public IActionResult Add (string name, float count, float price)  //Добавляем записи
        {
            _context.Goods.Add(new Order
            {
                Name = name,
                Count = count,
                Price = price
            });
            _context.SaveChanges();
            return Content("OK");
        }

        public IActionResult Edit (int id, string name, float count, float price) // Изменяем записи
        {
            var data = _context.Goods.FirstOrDefault(x => x.Count > 300);
            data.Name = name;
            data.Count = count;
            data.Price = price /100 * 10;
            _context.SaveChanges();
            return Content("Data is changed");
        }

        public IActionResult Remove(int id) //Удаляем записи
        {
            var data = _context.Goods.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                _context.Goods.Remove(data);
                _context.SaveChanges();
            }
            return Content("Data is deleted");
        }

        [HttpPost]
        public IActionResult Index(Regulars expr)
        {
            if (ModelState.IsValid)
            {
                OrderData.Items.Add(new Order()
                {
                    Name = expr.Name,
                    Count = expr.Count,
                    Price = expr.Price,
                });
                return RedirectToAction("Index");
            }
            return View(expr);
        }
       
    }
  

}
