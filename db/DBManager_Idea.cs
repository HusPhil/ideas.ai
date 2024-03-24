using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using Newtonsoft.Json;

namespace IdeasAi.db
{
    public class DBManager_Idea : DatabaseManager
    {

        public override void SaveObject(Idea obj)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = "INSERT INTO Idea (Id, Title, Input, Content, Date_created) VALUES (@Id, @Title, @Input, @Content, @Date_created)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", obj.UUID);
                    command.Parameters.AddWithValue("@Title", obj.Title);
                    command.Parameters.AddWithValue("@Input", obj.Input);
                    command.Parameters.AddWithValue("@Content", obj.Content);
                    command.Parameters.AddWithValue("@Date_created", obj.DateCreated);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Idea> getAllIdeas()
        {
            List<Idea> ideas = new List<Idea>();

            // Accessing the dbFilePath parameter directly instead of base.dbFilePath
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = "SELECT ID, Title, Input, Content, Date_created FROM Idea";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Idea idea = new Idea
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

                string query = $"UPDATE Idea SET {fieldName} = @NewValue WHERE ID = @Id";
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

                string query = "DELETE FROM Idea WHERE ID = @Id";
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
