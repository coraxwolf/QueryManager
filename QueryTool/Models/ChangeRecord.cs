using QueryManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTool.Models
{
  public class ChangeRecord
  {
    public enum RecordType
    {
      NewCourse,
      CanceledCourse,
      NewFaculty,
      FacultyAdded,
      FacultyRemoved,
      NotesChanged,
      StatusEvent
    };

    private readonly Course? courseRecord;
    private readonly Faculty? facultyRecord;
    private readonly string? note;
    private readonly DateOnly date;
    private readonly RecordType recordType;

    public ChangeRecord(RecordType changeType, Course? course, Faculty? faculty, string? notes)
    {
      recordType = changeType;
      courseRecord = course;
      facultyRecord = faculty;
      note = notes;
      date = DateOnly.FromDateTime(DateTime.Now);
    }

    public override string ToString()
    {
      return recordType switch
      {
        RecordType.NewCourse => $"[{date}] New Course Added {courseRecord?.SisId}.",
        RecordType.CanceledCourse => $"[{date}] Course {courseRecord?.SisId} has been canceled.",
        RecordType.NewFaculty => $"[{date}] Faculty Record for {facultyRecord?.Name} ({facultyRecord?.FacultyNo}) has been created.",
        RecordType.FacultyAdded => $"[{date}] Faculty {facultyRecord?.Name} ({facultyRecord?.FacultyNo}) has been assigned to course {courseRecord?.SisId}.",
        RecordType.FacultyRemoved => $"[{date}] Faculty {facultyRecord?.Name} ({facultyRecord?.FacultyNo}) has been removed from course {courseRecord?.SisId}.",
        RecordType.NotesChanged => $"[{date}] Course Notes Changed for {courseRecord?.SisId} to {note}.",
        RecordType.StatusEvent => $"Status: {note}.",
        _ => "Unknown Event or Error",
      };
    }
  }
}
