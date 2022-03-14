using System;
using System.Collections.IEnumerable;

namespace TimeTracker.Data.Models
{
    public class User : BaseEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
		public string Password {get; set;}
		public string Email {get; set;}
        public virtual ICollection<Week> LoggedWeeks {get; set;} 
    }
}