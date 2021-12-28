using Library.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.ViewComponents
{
    [ViewComponent(Name ="BookCounts")]
    public class ShowBookGroupsComponent : ViewComponent
    {
        private IBookGroupRepository _bookGroupRepository;
        public ShowBookGroupsComponent(IBookGroupRepository bookGroupRepository)
        {
            _bookGroupRepository = bookGroupRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View("Default", _bookGroupRepository.GetListGroups());
        }
    }
}
