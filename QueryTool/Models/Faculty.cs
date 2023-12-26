using QueryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Models
{
  public class Faculty
  {
    public string Name { get; set; }
    public string FacultyNo { get; set; }
    public string? CanvasName { get; set; }
    public Int32? CanvasCode { get; set; }
    public string? Email { get; set; }
    public List<Course> Courses { get; set; }

    public Faculty(string name, string facultyno, string? canvasName, string? email, Int32? canvasCode)
    {
      Name = name;
      FacultyNo = facultyno;
      CanvasName = canvasName;
      CanvasCode = canvasCode;
      Email = email;
      Courses = [];
    }
  }
}
