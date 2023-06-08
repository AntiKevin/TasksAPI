using Microsoft.EntityFrameworkCore;
using TasksAPI.Data.Map;
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
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefasMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
