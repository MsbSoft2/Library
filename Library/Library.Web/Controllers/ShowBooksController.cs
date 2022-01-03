﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class ShowBooksController : Controller
    {
        private IBookRepository _bookRepository;
        private IBookGroupRepository _bookGroupRepository;
        public ShowBooksController(IBookRepository bookRepository,IBookGroupRepository bookGroupRepository)
        {
            _bookRepository = bookRepository;
            _bookGroupRepository = bookGroupRepository;
        }

        [Route("Books/{bookId}")]
        public IActionResult ShowBooks(int bookId)
        {            
            var book = _bookRepository.GetBookById(bookId);
            
            var groupId = book.GroupID;
            var a=_bookGroupRepository.GetBookGroupById(groupId);
            ViewData["GroupName"]=a.GroupTitle.ToString();

            if(book != null)
            {
                book.BookVisit += 1;
                _bookRepository.UpdateBook(book);
                _bookRepository.Save();
            }
            return View(book);
        }
        
        [Route("Books/{groupId}/{title}")]
        public IActionResult ShowGroups(int groupId,string title)
        {
            ViewData["GroupTitle"] = title;
            var book = _bookRepository.GetBooksByGroupId(groupId);
            return View(book);
        }

        [Route("Search")]
        public IActionResult SearchInBooks(string parameter)
        {
            var book = _bookRepository.SearchInBooksByParameter(parameter);
            return View(book);
        }
    }
}