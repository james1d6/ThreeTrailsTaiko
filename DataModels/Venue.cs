using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.DataModels
{
	public class Venue : IVenue
	{
		public Venue()
		{

		}

		public int VenueID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public bool IsDeleted { get; set; }
		public string PostalCode { get; set; }
		public string WebsiteUrl { get; set; }
		public string MapUrl { get; set; }
	}
}
