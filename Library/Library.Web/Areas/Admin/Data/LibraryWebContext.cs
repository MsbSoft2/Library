using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Web.Models
{
    public class LibraryWebContext : DbContext
    {
        public LibraryWebContext (DbContextOptions<LibraryWebContext> options)
            : base(options)
        {
        }

        public DbSet<Library.Domain.Models.Book> Book { get; set; }
    }
}
