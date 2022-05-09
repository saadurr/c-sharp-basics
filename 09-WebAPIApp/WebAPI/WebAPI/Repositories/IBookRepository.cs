using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        
        Task<Book> Get(int id);
        Task<Book> Create(Book book);
        Task Update(Book book);
        Task<Book> Delete(int id);
    }
}
