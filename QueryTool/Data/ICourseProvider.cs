using QueryManager.Models;
using QueryTool.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data
{
  public interface ICourseProvider
  {

    Task<IEnumerable<Course>> GetAllCourses();
    Task<IEnumerable<Course>> GetCoursesByTerm(string term);
    Task<IEnumerable<Course>> GetCoursesByStartDate(DateOnly startDate);
    Task<Course> GetCourseById(string id);
  }
}
