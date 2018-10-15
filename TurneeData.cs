using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DiscGolfTurneeApp
{
    /// <summary>
    /// A data class for holding all data of current turnee.
    /// Also has XML reading and writing implementations
    /// </summary>
    public class TurneeData
    {
        public struct RoundData
        {
            public string courseName;
            public int[] pars;
            public PlayerScore[] playerScores;

            public RoundData(string courseName, int[] pars, PlayerScore[] playerScores)
            {
                this.courseName = courseName;
                this.pars = pars;
                this.playerScores = playerScores;
            }

            public override string ToString()
            {
                return courseName;
            }
        }

        public struct PlayerScore
        {
            public string playerName;
            public int[] scores;

            public PlayerScore(string playerName, int[] throws)
            {
                this.playerName = playerName;
                this.scores = throws;
            }
        }

        public List<RoundData> data { get; private set; }
        public List<string> players;

        public TurneeData()
        {
            data = new List<RoundData>();
            players = new List<string>();
        }

        public bool DeleteRound(RoundData rd)
        {
            return data.Remove(rd);
        }

        /// <summary>
        /// Combines two rounds. Check on par and player compatibility should be checked first!
        /// </summary>
        public void CombineRounds(RoundData r1, RoundData r2)
        {
            data.Remove(r1); data.Remove(r2);
            r1.playerScores = r1.playerScores.Concat(r2.playerScores).ToArray();
            data.Add(r1);
        }
       

        public void AddRoundFromFile(string filePath)
        {
            var s = filePath.Split('.');
            Debug.WriteLine(s[s.Length-1]);
            if (s[s.Length - 1].Equals("csv", StringComparison.OrdinalIgnoreCase))
            {
                AddRoundFromCSV(filePath);
            } else if (s[s.Length - 1].Equals("xml", StringComparison.OrdinalIgnoreCase))
            {
                AddRoundFromXML(filePath);
            }
            else
            {
                MessageBox.Show("Unknown file format");
            }
        }

        private void AddRoundFromXML(string filePath)
        {

            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(filePath);
                string courseName = doc.DocumentElement.Attributes["name"]?.InnerText + " - " + doc.DocumentElement.Attributes["time"]?.InnerText;

                var holes = doc.DocumentElement.ChildNodes;
                var players = holes[0].ChildNodes.Count;
                PlayerScore[] scores = new PlayerScore[players];

                for (int i = 0; i < players; i++)
                {
                    scores[i] = new PlayerScore(holes[0]?.ChildNodes[i].Attributes["player"].InnerText, new int[holes.Count]);
                }

                var pars = new int[holes.Count];

                for (int i = 0; i < holes.Count; i++)
                {
                    pars[i] = int.Parse(holes[i].Attributes["par"].InnerText);

                    for (int j = 0; j < players; j++)
                    {
                        scores[j].scores[i] = int.Parse(holes[i].ChildNodes[j].InnerText);
                    }
                }
                var round = new RoundData(courseName, pars, scores);
                data.Add(round);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was error loading file: \n\n" + e.GetType().ToString());
            }

        }

        private void AddRoundFromCSV(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            string line;
            string[] row;
            line = streamReader.ReadLine();
            row = line.Split(',');
            if (!row[0].Equals("PlayerName"))
            {
                Debug.WriteLine("Unknown csv format: First row: " + row[0]);
                MessageBox.Show("Unknown csv format");
                return;
            }
            line = streamReader.ReadLine();
            row = line.Split(',');
            var courseNameAndTime = row[1] + " | " + row[3];
            int[] pars = new int[row.Length - 6];
            for(int i = 0; i < pars.Length; i++)
            {
                pars[i] = int.Parse(row[i + 6]);
            }
            var playerScores = new List<PlayerScore>();
            while ((line = streamReader.ReadLine()) != null)
            {
                row = line.Split(',');
                var playerName = row[0];
                var scores = new int[row.Length - 6];
                for (int i = 0; i < pars.Length; i++)
                {
                    scores[i] = int.Parse(row[i + 6]);
                }
                playerScores.Add(new PlayerScore(playerName, scores));
            }
            data.Add(new RoundData(courseNameAndTime, pars, playerScores.ToArray()));
        }

        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
