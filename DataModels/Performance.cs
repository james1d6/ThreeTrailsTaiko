using System;
using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.DataModels
{
	public class Performance : IPerformance
	{
		public enum PerformanceType : int {
			All,
			Upcoming,
			Historical
		}

		public Performance()
		{

		}

		public int PerformanceID { get; set; }
		public int VenueID { get; set; }
		public string EventName { get; set; }
		public string Description { get; set; }
		public DateTime StartDate { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan StartTime2 { get; set; }
		public TimeSpan WorkshopTime { get; set; }
		public TimeSpan WorkshopTime2 { get; set; }
		public string EventUrl { get; set; }
		public bool IsDeleted { get; set; }
		public IVenue Venue { get; set; }

	}
}
