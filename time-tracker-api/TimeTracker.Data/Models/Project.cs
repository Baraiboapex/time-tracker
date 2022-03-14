using System.Collections.IEnumerable;
using System;

namespace TimeTracker.Data.Models
{
    public class Project : BaseEntity
    {
      public bool IsAwayTime {get; set;}
      public DateTime StartTime {get; set;}
      public DateTime EndTime {get; set;}
      public string EstimatedTime {get; set;}
      public virtual Guid? DayId {get; set;}
      public virtual Day Day {get; set;}
    }
}