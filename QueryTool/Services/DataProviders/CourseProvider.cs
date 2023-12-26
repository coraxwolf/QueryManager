using Microsoft.EntityFrameworkCore;
using QueryManager.Models;
using QueryTool.Data;
using QueryTool.Data.DTOs;
using QueryTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Services.DataProviders
{
  public class CourseProvider : ICourseProvider
  {

    private CourseContext courseContext;
    public CourseProvider(CourseContext context) 
    {
      courseContext = context;
    }
    private Course RecordToCourse(CourseRecord course)
    {
      Course newCourse = new(
        course.SisId,
        course.Term,
        course.ClassNo,
        course.Semester,
        course.Subject,
        course.Catalog,
        course.Title,
        course.Campus,
        course.Location,
        course.Status,
        course.Mode,
        course.Enrolled,
        course.Cap,
        course.StartDate,
        course.EndDate,
        course.CanvasName?? string.Empty,
        course.CanvasState ?? "UnKnown",
        course.CanvasCode,
        course.Notes
      );
      foreach (FacultyRecord faculty  in course.Faculty )
      {
        newCourse.Faculty.Add(new Faculty(faculty.Name, faculty.FacultyNo, faculty.CanvasName, faculty.Email, faculty.CanvasCode));
      }
      return newCourse;
    }
    public async Task<IEnumerable<Course>> GetAllCourses()
    {
      using ( var context = new CourseContext() )
      {
        IEnumerable<CourseRecord> courses = await context.Courses.ToListAsync();
        return courses.Select(r => RecordToCourse(r));
      }
    }

    public Task<Course> GetCourseById(string id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByStartDate(DateOnly startDate)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByTerm(string term)
    {
      throw new NotImplementedException();
    }
  }
}
