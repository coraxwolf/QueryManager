using QueryTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryManager.Models
{
  public class Course
  {
    public string SisId { get; set; }
    public string Term { get; set; }
    public string ClassNo { get; set; }
    public string Semester { get; set; }
    public string Subject { get; set; }
    public string Catalog { get; set; }
    public string Title { get; set; }
    public string Campus { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public string Mode { get; set; }
    public Int32 Enrolled { get; set; }
    public Int32 Cap { get; set; }
    public string? Notes { get; set; }
    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; }
    public string? CanvasName { get; set; } = string.Empty;
    public Int32? CanvasCode { get; set; }
    public string? CanvasState { get; set; } = "UnKnown";
    public List<Faculty> Faculty { get; set; }

    public string CourseName
    {
      get => $"{Subject} {Catalog}";
    }

    public Course(
      string sisId,
      string term, 
      string classNo, 
      string semester,
      string subject,
      string catalog,
      string title,
      string campus,
      string location,
      string status,
      string mode,
      int enrolled,
      int cap,
      DateOnly startDate,
      DateOnly endDate,
      string canvasName,
      string canvasState,
      int? canvasCode,
      string? notes)
    {
      SisId = sisId;
      Term = term;
      ClassNo = classNo;
      Semester = semester;
      Subject = subject;
      Catalog = catalog;
      Title = title;
      Campus = campus;
      Location = location;
      Status = status;
      Mode = mode;
      Enrolled = enrolled;
      Cap = cap;
      StartDate = startDate;
      EndDate = endDate;
      CanvasName = canvasName;
      CanvasCode = canvasCode;
      CanvasState = canvasState;
      Notes = notes;
      Faculty = [];
    }
  }
}
