﻿using System.IO;
using System.Data.SQLite;
using IdeasAi.Ideas;
using IdeasAi.Gemini_AI;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;


namespace IdeasAi.db
{
    public abstract class DatabaseManager
    {
        protected string dbFilePath { get; set; }
        protected string table { get; set; }

        public DatabaseManager()
        {
            string jsonString = File.ReadAllText("settings.json");
            var appSettings = JObject.Parse(jsonString);
            ScriptRunner.ReplaceEnvironmentVariables(appSettings);

            
            this.dbFilePath = (string)appSettings["Database_Path"];
            ;

            // Create the SQLite database file if it doesn't exist
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
        }

        //STATIC METHODS
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
        
    }
}
