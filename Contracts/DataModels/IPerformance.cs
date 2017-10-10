using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTrailsTaiko.Contracts.DataModels
{
	public interface IPerformance
	{
		int PerformanceID { get; set; }
		int VenueID { get; set; }
		string EventName { get; set; }
		string Description { get; set; }
		DateTime StartDate { get; set; }
		TimeSpan StartTime { get; set; }
		TimeSpan StartTime2 { get; set; }
		TimeSpan WorkshopTime {get;set;}
		TimeSpan WorkshopTime2 { get; set; }
		string EventUrl { get; set; }
		bool IsDeleted { get; set; }
		IVenue Venue { get; set; }
	}
}
