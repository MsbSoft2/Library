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
    public class RentController : Controller
    {
        private IRentRepository _rentRepository;
        private IBookRepository _bookRepository;
        public RentController(IRentRepository rentRepository, IBookRepository bookRepository)
        {
            _rentRepository = rentRepository;
            _bookRepository = bookRepository;
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> RentBook(int userId, int bookId, int countDay)
        {
            _rentRepository.InsertRent(new Rent()
            {
                BookID = bookId,
                UserId = userId,
                GetDate = DateTime.Now,
                CountDay = countDay
            });
            return Redirect("/");
        }

    }
}
