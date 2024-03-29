using System.IO;
using System.Data.SQLite;
using IdeasAi.Ideas;
using IdeasAi.Gemini_AI;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;


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

        public bool recordExist(Guid id)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"SELECT ID FROM {this.table}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (Guid.Parse(reader["ID"].ToString()).Equals(id))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public abstract void saveObject(DBObjectManager obj);

        public List<DBObjectManager> retrieveDBRecords()
        {
            List<DBObjectManager> ideas = new List<DBObjectManager>();

            // Accessing the dbFilePath parameter directly instead of base.dbFilePath
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"SELECT ID, Title, Input, Content, Date_created FROM {this.table}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DBObjectManager idea = new DBObjectManager
                            {
                                UUID = Guid.Parse(reader["ID"].ToString()),
                                Title = reader["Title"].ToString(),
                                Input = reader["Input"].ToString(),
                                Content = reader["Content"].ToString(),
                                DateCreated = DateTime.Parse(reader["Date_created"].ToString())
                            };
                            ideas.Add(idea);
                        }
                    }
                }
            }

            return ideas;
        }
        public void modifyField(Guid id, string fieldName, object newValue)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"UPDATE {this.table} SET {fieldName} = @NewValue WHERE ID = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Field modified successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. The ID might not exist in the database.");
                    }
                }
            }
        }
        public void deleteRecord(Guid id)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"DELETE FROM {this.table} WHERE ID = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. The ID might not exist in the database.");
                    }
                }
            }
        }
    }
}
