using DublinBikes_Macintosh.Data;
using Microsoft.AspNetCore.Mvc;
using DublinBikes_Macintosh.Models;
using System.Linq;

namespace DublinBikes_Macintosh.Controllers
{
    public class BikesViewController : Controller
    {
        private readonly DublinBikesContext _context;

        public BikesViewController(DublinBikesContext context)
        {
            _context = context;
        }

        public IActionResult Index(int limit)
        {
            if (limit == 0)
            {
                limit = 10;
            }
            ViewData["Limit"] = limit;
            BikeViewModel model = new BikeViewModel();
            model.Bike = _context.Bikes.ToList();

            ViewData["View"] = _context.Bikes.ToList();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            ViewData["Id"] = id;
            return View("Edit");
        }
    }
}