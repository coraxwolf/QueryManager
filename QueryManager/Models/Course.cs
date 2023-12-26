using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryManager.Models
{
  internal class Course
  {
    public string SisId { get; }
    public string Term { get; }
    public string ClassNo { get; }
    public string Semester { get; }
    public string Subject { get; }
    public string Catalog { get; }
    public string Title { get; }
    public string Campus { get; }
    public string Location { get; }
    public string Status { get; set; }
    public string Mode { get; }
    public Int32 Enrolled { get; set; }
    public Int32 Cap { get; }
    public DateOnly StartDate { get; }
    public DateOnly EndDate { get; }
    public string? CanvasName { get; set; }
    public Int32? CanvasCode { get; set; }
    public string? CanvasState { get; set; }

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
      int? canvasCode,
      string canvasState)
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
    }
  }
}
