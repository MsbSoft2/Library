using Library.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.ViewComponents
{
    [ViewComponent(Name = "TopBooks")]
    public class ShowTopBooksComponent : ViewComponent
    {
        private IBookRepository _bookRepository;
        public ShowTopBooksComponent(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View("Default", _bookRepository.GetTopBooks());
        }
    }
}
