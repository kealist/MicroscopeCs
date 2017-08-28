using MicroscopeLibrary.Models;
using MicroscopeLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroscopeLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath (this string filename)
        {
            return $"{ ConfigurationManager.AppSettings["filepath"] }\\{ filename }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        
        public static List<GameModel> ConvertToGameModels(this List<string> lines)
        {
            var games = new List<GameModel>();
            foreach (var line in lines)
            {
                string[] columns = line.Split(',');
                var game = new GameModel();
                game.Id = int.Parse(columns[0]);
                game.Description = columns[1];
                string[] periodsToParse = columns[2].Split('|');
                game.Periods = new List<PeriodModel>();
                foreach (var period in periodsToParse)
                {
                    game.Periods.Add(GlobalConfig.Connection.GetPeriod(int.Parse(period)));
                }
            }
            return games;
        }
    }
}
