using QueryTool.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data
{
  public interface IFacultyProvider
  {
    Task<IEnumerable<FacultyRecord>> GetAllFaculty();
    Task<FacultyRecord> GetFacultyById(string id);
  }
}
