using System.IO;
using System.Data.SQLite;
using IdeasAi.Ideas;
using IdeasAi.Gemini_AI;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;


namespace IdeasAi.db
{
    public abstract class DatabaseManager
    {
        MainForm mainForm;
        public string dbFilePath;
        public const string ConfigFilePath = "configs/settings.json";
        protected string table { get; set; }
        public DatabaseManager(MainForm mainForm)
        {
            this.mainForm = mainForm;
            var appConfig = mainForm.settings;
            ScriptRunner.ReplaceEnvironmentVariables(appConfig);
            dbFilePath = (string)appConfig["Database_Path"]["DEFAULT"];

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
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={this.dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"SELECT ID, Title, Input, Content, Date_modified FROM {this.table} ORDER BY Date_modified DESC";
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
                                DateCreated = DateTime.Parse(reader["Date_modified"].ToString())
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

        //STATIC METHODS
        public static void CreateNewNotebook(string dbName, string dbFilePath)
        {
            

            // SQL script to create tables
            try
            {
                string sqlScript = @"
            CREATE TABLE IF NOT EXISTS Document (
                ID UNIQUEIDENTIFIER PRIMARY KEY,
                Title TEXT,
                Input TEXT,
                Content TEXT,
                Date_modified DATE
            );

            CREATE TABLE IF NOT EXISTS Note (
                ID UNIQUEIDENTIFIER PRIMARY KEY,
                Title TEXT,
                Input TEXT,
                Content TEXT,
                Date_modified DATE
            );
        ";
                CreateDatabase(dbName, dbFilePath, sqlScript);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Creating a notebook failed: {ex.Message}");
            }
            // Call the method to create the database

        }
        public static void AddNewDatabasePath(string key, string path, JObject appConfig)
        {
            try
            {
                // Access the "Database_Path" property
                JObject databasePath = (JObject)appConfig["Database_Path"];

                // Add a new key-value pair to the "Database_Path" property
                databasePath[key] = path;

                // Write the modified JSON back to the file
                File.WriteAllText(ConfigFilePath, JsonConvert.SerializeObject(appConfig, Formatting.Indented));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Adding a DB path failed: {ex.Message}");
            }
            
        }
        public static void RemoveDatabasePath(string key)
        {

        }
        public static string[] GetDatabasePathKeys(JObject appConfig)
        {
            string[] keys = null;
            try
            {    
                JObject databasePath = (JObject)appConfig["Database_Path"];
                keys = databasePath.Properties().Select(p => p.Name).ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Getting db path keys failed: {ex.Message}");
            }

            return keys;
        }
        public static void CreateDatabase(string dbName, string dbFilePath, string sqlScript)
        {
            try
            {
                // Check if the database file already exists
                if (File.Exists(dbFilePath))
                {
                    Console.WriteLine("Database file already exists.");
                    throw new Exception("Database file already exists.");
                }

                string connectionString = $"Data Source={dbFilePath};Version=3;";
                SQLiteConnection.CreateFile(dbFilePath);
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sqlScript, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Close the connection
                    connection.Close();
                }

                Console.WriteLine("Database created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Creating a DB failed: {ex.Message}");
            }
            
        }
        public static string OpenTextFile(string filePath)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read all text from the file and return it
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        return reader.ReadToEnd();
                    }
                }
                else
                {
                    // File doesn't exist
                    Console.WriteLine("The specified file does not exist.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Exception occurred while reading the file
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return null;
            }
        }
        public static bool SaveStringAsTextFile(string filePath, string content)
        {
            try
            {
                // Write the content to the specified file path
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }
                return true; // File saved successfully
            }
            catch (Exception ex)
            {
                // Exception occurred while writing to the file
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
                return false; // File saving failed
            }
        }
        //
        //
        
    }
}
