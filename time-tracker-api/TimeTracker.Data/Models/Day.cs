using System.Collections.IEnumerable;
using System;

namespace TimeTracker.Data.Models
{
    public class Day : BaseEntity
    {
        public DateTime Date {get; set;}
		public string DayOfTheWeek {get; set;}
		public bool HasDayOff {get; set;}
        public virtual ICollection<Project> Project {get; set;}
        public virtual Guid? WeekId {get; set;}
        public virtual Week Week {get; set;}
		//See EF Note 2
    }
}