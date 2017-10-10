using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTrailsTaiko.Contracts.DataModels
{
	public interface IVenue
	{
		int VenueID { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string Street { get; set; }
		string City { get; set; }
		string State { get; set; }
		string PostalCode { get; set; }
		string WebsiteUrl { get; set; }
		string MapUrl { get; set; }
		bool IsDeleted { get; set; }
	}
}
