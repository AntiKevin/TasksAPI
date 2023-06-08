using Microsoft.EntityFrameworkCore;
using TasksAPI.Models;

namespace TasksAPI.Data
{
    public class TasksDBContext: DbContext
    {
        public TasksDBContext(DbContextOptions<TasksDBContext> options)
            : base(options)
        { 
        }
        
        public DbSet<UsuarioModel> Usuarios { get; set;}
        public DbSet<TarefasModel> Tarefas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
