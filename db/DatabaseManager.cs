using System.IO;
using System.Data.SQLite;
using IdeasAi.Ideas;
using IdeasAi.Gemini_AI;
using Newtonsoft.Json;


namespace IdeasAi.db
{
    public abstract class DatabaseManager
    {
        protected string dbFilePath { get; set; }
        protected string table { get; set; }

        public DatabaseManager()
        {
            string jsonString = File.ReadAllText("settings.json");
            var appSettings = JsonConvert.DeserializeObject<AppSettings>(jsonString);
            var dbPath = appSettings.DBPath;
            this.dbFilePath = dbPath;

            // Create the SQLite database file if it doesn't exist
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
        }

        public abstract void SaveObject(Idea obj);
        
    }
}
