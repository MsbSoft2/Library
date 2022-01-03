using Library.Core.Repositories;
using Library.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    public class RentsController : Controller
    {
        private IRentRepository _rentRepository;
        private IBookRepository _bookRepository;
        public RentsController(IRentRepository rentRepository, IBookRepository bookRepository)
        {
            _rentRepository = rentRepository;
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            return View();
        }


        // GET: RentsController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = _rentRepository.GetRentById(id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        public IActionResult Create()
        {
            ViewData["BookID"] = new SelectList(_bookRepository.GetAllBooks(), "BookID");
            return View();
        }

        // POST: Admin/Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisableRequestSizeLimit,
    RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue,
        ValueLengthLimit = int.MaxValue)]
        public async Task<IActionResult> Create([Bind("RentID , BookID")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                _rentRepository.InsertRent(rent);
                _rentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookID"] = new SelectList(_rentRepository.GetAllRent(), "BookID", rent.BookID);
            return View(rent);
        }

        // GET: RentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
