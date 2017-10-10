using System.Data.SqlClient;
using ThreeTrailsTaiko.Contracts.DataModels;
using ThreeTrailsTaiko.Contracts.Repositories;
using ThreeTrailsTaiko.Data;
using ThreeTrailsTaiko.DataModels;

namespace ThreeTrailsTaiko.Repositories
{
	public class SlideShowRepository : ISlideShowRepository
	{
		public ISlideShow GetSlideShowByAlias(string alias)
		{
			var slideShow = new SlideShow();
			using (var connection = SQL.CreateConnection())
			{
				connection.Open();
				using (var command = new SqlCommand() { CommandText = "usp_SelectSlideShowByAlias", CommandType = System.Data.CommandType.StoredProcedure, Connection = connection })
				{
					command.Parameters.AddWithValue("@Alias", alias);
					using (SqlDataReader dataReader = command.ExecuteReader())
					{
						var firstRow = true;
						while (dataReader.Read())
						{
							if (firstRow)
							{
								slideShow.SlideShowID = (int)dataReader["SlideShowID"];
								slideShow.Alias = (string)dataReader["Alias"];
								firstRow = false;
							}

							slideShow.Slides.Add(new Slide()
							{
								SlideID = (int)dataReader["SlideID"],
								SlideShowID = (int)dataReader["SlideShowID"],
								Caption = (string)dataReader["Caption"],
								ImagePath = (string)dataReader["ImagePath"],
								SortOrder = (int)dataReader["SortOrder"]
							});
						}
					}
				}
			}
			return slideShow;
		}
	}
}