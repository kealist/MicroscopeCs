using MicroscopeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MicroscopeLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool json)
        {
            if (database)
            {
                // TODO - Create the MS SQL Express Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (json) {
                // TODO - Create the JSON Connection
                JsonConnector jsonCon = new JsonConnector();
                Connections.Add(jsonCon);

            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
