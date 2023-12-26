using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Data.DTOs
{
  public class FacultyRecord
  {
    [Key]
    public String FacultyNo { get; set; }
    public string Name { get; set; }
    public string? CanvasName { get; set; }
    public string? Email { get; set; }
    public Int32? CanvasCode { get; set; }
    public List<CourseRecord> Courses { get; set; }
  }
}
