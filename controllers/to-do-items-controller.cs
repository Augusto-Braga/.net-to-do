using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using to_do_api.Data;
using to_do_api.Models;

namespace to_do_api.Controllers
{
    [Route("api/todoitems")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ToDoItemsController(ToDoContext context)
        {
            _context = context;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> GetToDoItems()
        {
            // Retorna todos os ToDoItems do banco de dados
            return await _context.ToDoItems.ToListAsync();
        }

           // POST: api/todoitems
        [HttpPost]
        public async Task<ActionResult<ToDoItem>> PostToDoItem(ToDoItem todoItem)
        {
            // Adiciona o novo ToDoItem ao contexto
            _context.ToDoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            // Retorna uma resposta indicando que o item foi criado com sucesso
            return CreatedAtAction(nameof(GetToDoItems), new { id = todoItem.Id }, todoItem);
        }
    }
}