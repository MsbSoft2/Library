using Library.Core.Repositories;
using Library.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private IBookRepository _bookRepository;
        private IBookGroupRepository _bookGroupRepository;
        public BooksController(IBookRepository bookRepository, IBookGroupRepository bookGroupRepository)
        {
            _bookRepository = bookRepository;
            _bookGroupRepository = bookGroupRepository;
        }


        // GET: Admin/Books
        public async Task<IActionResult> Index()
        {
            return View(_bookRepository.GetAllBooks());
        }

        // GET: Admin/Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Book = _bookRepository.GetBookById(id.Value);
            if (Book == null)
            {
                return NotFound();
            }

            return View(Book);
        }

        // GET: Admin/Books/Create
        public IActionResult Create()
        {
            ViewData["GroupID"] = new SelectList(_bookGroupRepository.GetAllBookGroups(), "GroupID", "GroupTitle");
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
        public async Task<IActionResult> Create([Bind("BookID,GroupID,BookName,ShortDescription,Author,PublisherName,PublishYear,ISBNNumber,ImageName,ShowInSlider,BookVisit")] Book book, IFormFile imgup)
        {
            if (ModelState.IsValid)
            {
                book.BookVisit = 0;
                book.PublishYear = DateTime.Now;

                if (imgup != null)
                {
                    book.ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgup.FileName);
                    string SavePath = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot", "contents", "BookImages", book.ImageName
                        );
                    using (FileStream stream = new FileStream(SavePath, FileMode.Create))
                    {
                        await imgup.CopyToAsync(stream);
                    }
                }

                _bookRepository.InsertBook(book);
                _bookRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupID"] = new SelectList(_bookRepository.GetAllBooks(), "GroupID", "GroupTitle", book.GroupID);
            return View(book);
        }

        //public async Task WriteToDisk(string SavePath, IFormFile imgup)
        //{
        //    using (FileStream stream = new FileStream(SavePath, FileMode.Create))
        //    {
        //        await imgup.CopyToAsync(stream);
        //    }
        //}

        // GET: Admin/Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _bookRepository.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["GroupID"] = new SelectList(_bookGroupRepository.GetAllBookGroups(), "GroupID", "GroupTitle", book.GroupID);
            return View(book);
        }

        // POST: Admin/Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //    [DisableRequestSizeLimit,
        //RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue,
        //    ValueLengthLimit = int.MaxValue)]
        [RequestSizeLimit(40000000)]
        public async Task<IActionResult> Edit(int id, [Bind("BookID,GroupID,BookName,ShortDescription,Author,PublisherName,PublishYear,ISBNNumber,ImageName,ShowInSlider,BookVisit")] Book book, IFormFile imgup)
        {
            if (id != book.BookID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (imgup != null)
                    {
                        if (book.ImageName == null)
                        {
                            book.ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgup.FileName);
                        }
                        string SavePath = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot", "contents", "BookImages", book.ImageName
                            );
                        using (FileStream stream = new FileStream(SavePath, FileMode.Create))
                        {
                            await imgup.CopyToAsync(stream);
                        }

                    }

                    _bookRepository.UpdateBook(book);
                    _bookRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookID))
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
            ViewData["GroupID"] = new SelectList(_bookGroupRepository.GetAllBookGroups(), "GroupID", "GroupTitle", book.GroupID);
            return View(book);
        }

        // GET: Admin/Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _bookRepository.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Admin/Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = _bookRepository.GetBookById(id);
            _bookRepository.DeleteBook(book);

            if (book.ImageName != null)
            {
                var ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","contents" , "BookImages", book.ImageName);
                if (System.IO.File.Exists(ImagePath))
                {
                    System.IO.File.Delete(ImagePath);
                }
            }

            _bookRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _bookRepository.BookExsist(id);
        }
    }
}
