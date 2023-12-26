using Microsoft.EntityFrameworkCore;
using QueryTool.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data
{
  public class CourseContext : DbContext
  {
    public DbSet<CourseRecord> Courses { get; set; }
    public DbSet<FacultyRecord> Faculty {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=courses.db");
      base.OnConfiguring(optionsBuilder);
    }
  }
}
