using System.Collections.IEnumerable;
using System.Collections.Generic;
using System;

namespace TimeTracker.Data.Models
{
    public class Week : BaseEntity
    {
        public DateTime WeekStartDate {get; set;} //<== See EF Note 1
        public DateTime WeekEndDate {get; set;} //<== See EF Note 1
		public bool IncludeSaturday {get; set;}
		public bool IncludeSunday {get; set;}
		public List<string> DaysOff {get; set;}
		public bool HasWeekOff {get; set;}
	    public virtual ICollection<Day> Days {get; set;}
        public virtual Guid? UserId {get; set;}
        public virtual User User {get; set;}
    }
}