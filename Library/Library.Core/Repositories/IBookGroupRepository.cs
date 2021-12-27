using Library.Core.DTOs;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookGroupRepository
    {
        List<BookGroup> GetAllBookGroups();
        BookGroup GetBookGroupById(int groupId);
        void InsertBookGroup(BookGroup bookGroup);
        void UpdateBookGroup(BookGroup bookGroup);
        void DeleteBookGroup(BookGroup bookGroup);
        void DeleteBookGroupById(int groupId);
        bool IsExistsBookGroup(int groupId);
        List<ShowGroupsViewModels> GetListGroups();
        void Save();
    }
}
