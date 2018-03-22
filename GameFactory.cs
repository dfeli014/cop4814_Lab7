using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Games
{
    public class GameFactory
    {
        public List<Game> gameList = new List<Game>();
        public string FilePath { get; set; }

        public void CreateGameList()
        {
            Game g1 = new Game("Friends", "Foes", "100", "99");
            Game g2 = new Game("Brothers", "Sisters", "123", "59");
            Game g3 = new Game("Parents", "Children", "85", "109");
            Game g4 = new Game("Celtics", "Lakers", "40", "76");
            Game g5 = new Game("Teachers", "Students", "87", "112");
            Game g6 = new Game("France", "USA", "59", "63");

            gameList.Add(g1);
            gameList.Add(g2);
            gameList.Add(g3);
            gameList.Add(g4);
            gameList.Add(g5);
            gameList.Add(g6);
        }

        public void SerializeGameList()
        {
            XmlSerializer serial;
            StreamWriter sw;
            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FilePath);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public List<Game> DeserializeGameList()
        {
            StreamReader sr = new StreamReader(FilePath);
            XmlSerializer serial = new XmlSerializer(gameList.GetType());
            gameList = (List<Game>)serial.Deserialize(sr);
            sr.Close();
            return gameList;
        }
    }
}
