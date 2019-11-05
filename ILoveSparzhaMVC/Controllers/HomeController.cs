using ILoveSparzhaMVC.Entities;
using ILoveSparzhaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ILoveSparzhaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly EFContext _context;
        public HomeController()
        {
            _context = new EFContext();
        }

        // Список любителей спаржи
        public async Task<ActionResult> Index()
        {
            var model = await _context.Users
                .Select(x => new UserViewModel
                {
                    Name = x.Name,
                    Date = x.CreatedDate,
                    Counter = x.Counter
                }).ToListAsync();

            return View(model);
        }

        // добаить 
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(AddUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(model.Email));
                if(user != null)
                {
                    user.Counter++;
                    _context.Entry(user).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.Users.Add(new Entities.User
                    {
                        Email = model.Email,
                        Name = model.Name
                    });
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}