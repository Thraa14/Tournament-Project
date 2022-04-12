﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentProject.DataAccess;

namespace TournamentProject
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PersonFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchUpFile = "MatchUpModel.csv";
        public const string MatchUpEntryFile = "MatchUpEntryModel.csv";

        public static string AppKeyLogin(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static IDataConnection Connection { get; private set; }
        public static void intializConnection(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                 
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.Textfile)
            {
                
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string ConString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
