using Library.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RentController : Controller
    {
        private readonly IRentRepository _rentRepository;
        public RentController(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }
        public IActionResult Index()
        {
            return View(_rentRepository.GetAllRent());
        }
        public IActionResult BackBook(int bookId)
        {
            _rentRepository.DeleteRentById(bookId);
            _rentRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
