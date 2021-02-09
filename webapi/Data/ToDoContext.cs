using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<webapi.Models.ToDoItem> ToDoItem { get; set; }
    }
