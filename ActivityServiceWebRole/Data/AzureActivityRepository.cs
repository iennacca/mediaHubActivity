using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure;

using Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling;
using ActivityServiceWebRole.Data;

namespace ActivityServiceWebRole.Data
{
    public class AzureActivityRepository : IActivityDetailRepository
    {
        public AzureActivityRepository()
        {
            // set up retry strategy [EnterpriseLibrary Transient Fault Handling Block]
            var strategy = new FixedInterval("fixed", 10, TimeSpan.FromSeconds(3));
            var strategies = new List<RetryStrategy> { strategy };
            var manager = new RetryManager(strategies, "fixed");
            RetryManager.SetDefault(manager, false);
        }

        public IQueryable<ActivityDetailDataContract> GetActivityDetails()
        {
            return getActivityDetailsUsingADO().AsQueryable<ActivityDetailDataContract>();
        }

        public IQueryable<ActivityDetailDataContract> getActivityDetailsUsingLinqToSQL()
        {
            var dbContext = new MediaHubActivityDataContext();

            var query = from a in dbContext.j30t_changelogs.OrderBy((d) => -d.j30c_date).Take(10)
                        select a.Transform();

            return query;
        }

        private IEnumerable<ActivityDetailDataContract> getActivityDetailsUsingADO()
        {
            //var connectionString = getAzureConnectionString().ConnectionString;
            //var connectionString = ConfigurationManager.ConnectionStrings["mediaHubActivityConnectionString"].ConnectionString;
            var connectionString = CloudConfigurationManager.GetSetting("mediaHubActivityConnectionString");

            using (var connection = new ReliableSqlConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP 10000 * FROM j30t_changelog ORDER BY j30c_date DESC";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            yield return reader.Transform();
                    }
                }
                connection.Close();
            }
        }

        private static SqlConnectionStringBuilder getLocalhostConnectionString()
        {
            return new SqlConnectionStringBuilder
            {
                UserID = "",
                Password = "",
                DataSource = "NEO",
                InitialCatalog = "mediaHubActivity",
                TrustServerCertificate = false,
                Encrypt = false,
                IntegratedSecurity = true
            };
        }

        private static SqlConnectionStringBuilder getAzureConnectionString()
        {
            throw new NotImplementedException("Credentials redacted from source; please recompile.");
        }
    }

    public static class Transformations
    {
        public static ActivityDetailDataContract Transform(this SqlDataReader reader)
        {
            return new ActivityDetailDataContract
            {
                Action = reader["j30c_action"].ToString(),
                DateTimeStamp = new DateTime(1970, 1, 1).AddMilliseconds(Convert.ToInt64(reader["j30c_date"])),
                Description = reader["j30c_description"].ToString(),
                UserName = reader["j30c_user_name"].ToString()
            };
        }

        public static ActivityDetailDataContract Transform(this ActivityDetail from)
        {
            return new ActivityDetailDataContract
            {
                Action = from.j30c_action,
                DateTimeStamp = System.DateTime.Now,
                Description = from.j30c_description,
                UserName = from.j30c_user_name
            };
        }

        public static ActivityDetailDataContract Transform(this j30t_changelog from)
        {
            return new ActivityDetailDataContract
            {
                Action = from.j30c_action,
                DateTimeStamp = new DateTime(1970, 1, 1).AddMilliseconds(Convert.ToInt64(from.j30c_date)),
                Description = from.j30c_description,
                UserName = from.j30c_user_name
            };
        }
    }

}