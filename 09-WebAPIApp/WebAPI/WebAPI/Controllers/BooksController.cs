using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;

        public BooksController(IBookRepository bookRepo)
        {
            this._bookRepo = bookRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepo.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>>GetBooks(int id)
        {
            return await _bookRepo.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Book>>PostBooks([FromBody] Book book)
        {
            var newItem = await _bookRepo.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newItem.ID }, newItem);
        }

        [HttpPut]
        public async Task<ActionResult> PutBooks(int id, [FromBody] Book book)
        {
            if(id != book.ID)
            {
                return BadRequest();
            }

            await _bookRepo.Update(book);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var itemToDelete = await _bookRepo.Get(id);
            if(itemToDelete == null)
            {
                return NotFound();
            }
            await _bookRepo.Delete(itemToDelete.ID);
            return NoContent();
        }

    }
}
