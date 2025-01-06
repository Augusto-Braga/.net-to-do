using Microsoft.EntityFrameworkCore;
using to_do_api.Models;

namespace to_do_api.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {            
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}