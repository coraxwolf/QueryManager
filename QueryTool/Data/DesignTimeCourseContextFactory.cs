using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data
{
  public class DesignTimeCourseContextFactory : IDesignTimeDbContextFactory<CourseContext>
  {
    public CourseContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<CourseContext>();
      optionsBuilder.UseSqlite("Data Source=courses.db");
      return new CourseContext(optionsBuilder.Options);
    }
  }
}
