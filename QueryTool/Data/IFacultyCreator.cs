using QueryTool.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data
{
  public interface IFacultyCreator
  {
    Task CreateFaculty(FacultyRecord faculty);
    Task UpdateFaculty(FacultyRecord faculty);
  }
}
