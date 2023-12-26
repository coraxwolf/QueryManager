using Microsoft.EntityFrameworkCore;
using QueryManager.Models;
using QueryTool.Data;
using QueryTool.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Services.DataCreators
{
  public class CourseCreator : ICourseCreator
  {
    private CourseContext dbContext;
    public CourseCreator(CourseContext courseContext)
    {
      dbContext = courseContext;
    }

    public async Task CreateCourse(CourseRecord course)
    {
      using (dbContext)
      {
        dbContext.Courses.Add(course);
        await dbContext.SaveChangesAsync();
      }
    }

    public async Task UpdateCourse(CourseRecord course)
    {
      using (dbContext)
      {
        CourseRecord? curRecord = dbContext.Courses.FirstOrDefault(r => r.SisId == course.SisId);
        if (curRecord != null)
        {
          curRecord = course; // Replace existing data with new data
          await dbContext.SaveChangesAsync();
        }
      }
    }
  }
}
