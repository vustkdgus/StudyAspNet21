using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoListWebApp.Models;

namespace TodoListWebApp.Data
{
    public class TodoListWebAppContext : DbContext
    {
        public TodoListWebAppContext (DbContextOptions<TodoListWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TodoListWebApp.Models.Todo> Task { get; set; }
    }
}
