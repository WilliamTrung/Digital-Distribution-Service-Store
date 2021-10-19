using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;


namespace DigitalDistributionStoreWinApp
{
    class DBInteraction
    {
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
                
        }
    }
}
