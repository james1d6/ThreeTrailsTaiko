using System.Data;
using System.Data.SqlClient;
using ThreeTrailsTaiko.Contracts.DataModels;
using ThreeTrailsTaiko.Contracts.Repositories;
using ThreeTrailsTaiko.Data;
using ThreeTrailsTaiko.DataModels;

namespace Respositories
{
	public class VenueRepository : IVenueRepository
	{
		public IVenue CreateFromReader(IDataReader dataReader, string prefix = "")
		{
			var v = new Venue();
			Fill(v, dataReader);
			return v;
		}

		private void Fill(IVenue venue, IDataReader dataReader, string prefix = "")
		{
			var sqlDataReader = dataReader as SqlDataReader;

			venue.VenueID = sqlDataReader.GetSafe<int>("VenueID");
			venue.Name = sqlDataReader.GetSafe<string>($"{prefix}VenueName");
			venue.Description = sqlDataReader.GetSafe<string>($"{prefix}VenueDescription");
			venue.Street = sqlDataReader.GetSafe<string>($"{prefix}VenueStreet");
			venue.City = sqlDataReader.GetSafe<string>($"{prefix}VenueCity");
			venue.State = sqlDataReader.GetSafe<string>($"{prefix}VenueState");
			venue.PostalCode = sqlDataReader.GetSafe<string>($"{prefix}VenuePostalCode");
			venue.WebsiteUrl = sqlDataReader.GetSafe<string>($"{prefix}VenueWebsiteUrl");
			venue.MapUrl = sqlDataReader.GetSafe<string>($"{prefix}VenueMapUrl");
			venue.IsDeleted = sqlDataReader.GetSafe<bool>($"{prefix}VenueIsDeleted");
		}
	}
}
