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
        
        public static List<GameElementModel> ConvertToGameModels(this List<string> lines)
        {
            var games = new List<GameElementModel>();
            foreach (var line in lines)
            {
                string[] columns = line.Split(',');
                var game = new GameElementModel
                {
                    Id = int.Parse(columns[0]),
                    Description = columns[1]
                };
                string[] periodsToParse = columns[2].Split('|');
                game.Children = new List<GameElementModel>();
                foreach (var period in periodsToParse)
                {
                    game.Children.Add(GlobalConfig.Connection.GetPeriod(int.Parse(period)));
                }
            }
            return games;
        }
    }
}
