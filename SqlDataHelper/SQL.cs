using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ThreeTrailsTaiko.Data
{
    public static class SQL 
    {
		public static string DB_CONNECTION_STRING => System.Web.Configuration.WebConfigurationManager.AppSettings["DBConnectionString"];

		public static SqlConnection CreateConnection()
		{
			return new SqlConnection(DB_CONNECTION_STRING);
		}

		public static T GetSafe<T>(this SqlDataReader dataReader, string name)
		{
			if (dataReader[name] == null || dataReader[name] == System.DBNull.Value)
			{
				return default(T);
			}
			return (T)dataReader[name];
		}

		public static IEnumerable<SqlDataReader> GetDataReader(string sql)
		{
			using (SqlConnection cn = CreateConnection())
			{
				cn.Open();
				using (SqlCommand command = new SqlCommand(sql, cn))
				{
					command.CommandType = System.Data.CommandType.StoredProcedure;
					using (SqlDataReader dr = command.ExecuteReader())
					{
						while (dr.Read())
						{
							yield return dr;
						}
					}
				}
			}
		}
	}
}
