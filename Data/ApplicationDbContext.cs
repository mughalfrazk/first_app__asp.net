using Microsoft.EntityFrameworkCore;
using mvc.Models;

namespace mvc.Data;
public class ApplicationDbContext :DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {
    
  }

  public DbSet<Category> Categories { get; set; }
} 