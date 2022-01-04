using Library.Core.Repositories;
using Library.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookGroupsController : Controller
    {
        private IBookGroupRepository _bookGroupRepository;
        public BookGroupsController(IBookGroupRepository bookGroupRepository)
        {
            _bookGroupRepository = bookGroupRepository;
        }

        // GET: Admin/BookGroups
        public async Task<IActionResult> Index()
        {
            return View(_bookGroupRepository.GetAllBookGroups());
        }

        // GET: Admin/BookGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGroup = _bookGroupRepository.GetBookGroupById(id.Value);
            if (bookGroup == null)
            {
                return NotFound();
            }

            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BookGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupID,GroupTitle")] BookGroup bookGroup)
        {
            if (ModelState.IsValid)
            {
                _bookGroupRepository.InsertBookGroup(bookGroup);
                _bookGroupRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGroup = _bookGroupRepository.GetBookGroupById(id.Value);
            if (bookGroup == null)
            {
                return NotFound();
            }
            return View(bookGroup);
        }

        // POST: Admin/BookGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupID,GroupTitle")] BookGroup bookGroup)
        {
            if (id != bookGroup.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bookGroupRepository.UpdateBookGroup(bookGroup);
                    _bookGroupRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookGroupExists(bookGroup.GroupID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookGroup);
        }

        // GET: Admin/BookGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookGroup = _bookGroupRepository.GetBookGroupById(id.Value);
            if (bookGroup == null)
            {
                return NotFound();
            }

            return View(bookGroup);
        }

        // POST: Admin/BookGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookGroup = _bookGroupRepository.GetBookGroupById(id);
            _bookGroupRepository.DeleteBookGroup(bookGroup);
            _bookGroupRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool BookGroupExists(int id)
        {
            return _bookGroupRepository.IsExistsBookGroup(id);
        }
    }
}
