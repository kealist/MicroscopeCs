﻿using MicroscopeLibrary.DataAccess;
using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace MicroscopeLibrary
{
    public static class GlobalConfig
    {
        public static GameModel CurrentGame { get; set; }
        public static bool UnsavedChanges { get; set; } = true;
        public enum ConnectionType { EntityFramework, Json } ;
        /// <summary>
        /// 
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.EntityFramework:
                    EntityConnector sql = new EntityConnector();
                    Connection = sql;
                    break;

                case ConnectionType.Json:
                    JsonConnector jsonCon = new JsonConnector();
                    Connection = jsonCon;
                    break;
            }
        }
        
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
