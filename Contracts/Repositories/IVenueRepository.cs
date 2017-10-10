using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.Contracts.Repositories
{
	public interface IVenueRepository
	{
		IVenue CreateFromReader(IDataReader dataReader, string prefix);
		
	}
}
