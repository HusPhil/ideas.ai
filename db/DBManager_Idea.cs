using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using IdeasAi.Gemini_AI;
using IdeasAi.Ideas;
using Newtonsoft.Json;

namespace IdeasAi.db
{
    internal class DBManager_Idea : DatabaseManager
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

        public List<Idea> GetAllIdeas()
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

    }
}
