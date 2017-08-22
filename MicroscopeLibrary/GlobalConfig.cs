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
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(bool database, bool json)
        {
            if (database)
            {
                // TODO - Create the MS SQL Express Connection
                EntityConnector sql = new EntityConnector();
                Connection = sql;
            }
            else if (json) {
                // TODO - Create the JSON Connection
                JsonConnector jsonCon = new JsonConnector();
                Connection = jsonCon;

            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
