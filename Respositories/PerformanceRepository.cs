using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ThreeTrailsTaiko.Contracts.DataModels;
using ThreeTrailsTaiko.Contracts.Repositories;
using ThreeTrailsTaiko.Data;
using ThreeTrailsTaiko.DataModels;

namespace Respositories
{
	public class PerformanceRepository : IPerformanceRepository
	{
		IVenueRepository _venueRepository;

		public PerformanceRepository(IVenueRepository venueRepository)
		{
			_venueRepository = venueRepository;
        }

		public IPerformance CreateFromReader(IDataReader dataReader, string prefix = "")
		{
			var p = new Performance();
			Fill(p, dataReader);
			return p;
		}
		private void Fill(IPerformance performance, IDataReader dataReader, string prefix = "")
		{
			var sqlDataReader = dataReader as SqlDataReader;

			performance.PerformanceID = sqlDataReader.GetSafe<int>("PerformanceID");
			performance.EventName = sqlDataReader.GetSafe<string>($"{prefix}EventName");
			performance.Description = sqlDataReader.GetSafe<string>($"{prefix}Description");
			performance.EventUrl = sqlDataReader.GetSafe<string>($"{prefix}EventUrl");
			performance.StartDate = sqlDataReader.GetSafe<DateTime>($"{prefix}StartDate");
			performance.StartTime = sqlDataReader.GetSafe<TimeSpan>($"{prefix}StartTime");
			performance.StartTime2 = sqlDataReader.GetSafe<TimeSpan>($"{prefix}StartTime2");
			//performance.WorkshopTime = (TimeSpan)item("WorkshopTime");
			//performance.WorkshopTime2 = (TimeSpan)item("WorkshopTime2");
			performance.IsDeleted = sqlDataReader.GetSafe<bool>($"{prefix}IsDeleted");
			performance.VenueID = sqlDataReader.GetSafe<int>($"{prefix}VenueID");

		}

		public List<IPerformance> GetAllPerformances()
		{
			throw new NotImplementedException();
		}

		public List<IPerformance> GetPastPerformances()
		{
			var reader = SQL.GetDataReader("usp_SelectPastPerformances");
			var performances = new List<IPerformance>();

			foreach (var item in reader)
			{
				var p = CreateFromReader(item);
				p.Venue = _venueRepository.CreateFromReader(item, "Venue");
				performances.Add(p);
			}
			return performances;
		}

		public List<IPerformance> GetUpcomingPerformances()
		{
			var reader = SQL.GetDataReader("usp_SelectUpcomingPerformances");
			var performances = new List<IPerformance>();

			foreach (var item in reader)
			{
				var p = CreateFromReader(item);
				p.Venue = _venueRepository.CreateFromReader(item, "Venue");
				performances.Add(p);
			}
			return performances;
		}

		public void Save(IPerformance performance)
		{
			throw new NotImplementedException();
		}
	}
}
