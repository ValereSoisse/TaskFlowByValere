using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskFlowByValere.Models;

namespace TaskFlowByValere.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Projet> Projets { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}