using Microsoft.EntityFrameworkCore;

namespace minimalAPI

{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) 
            : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}

//The preceding code defines the database context,
//which is the main class that coordinates Entity Framework functionality for a data model.
//This class derives from the Microsoft.EntityFrameworkCore.DbContext class.