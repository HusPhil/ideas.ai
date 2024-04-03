using System;
using System.Collections.Generic;
using System.Data.SQLite;
using IdeasAi.Ideas;

namespace IdeasAi.db
{
    public class DBManager_Note : DatabaseManager
    {
        public DBManager_Note()
        {
            table = "Note";
        }

        public override void saveObject(DBObjectManager obj)
        {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
            {
                connection.Open();

                string query = $"INSERT INTO {this.table} (Id, Title, Input, Content, Date_modified) VALUES (@Id, @Title, @Input, @Content, @Date_modified)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", obj.UUID);
                    command.Parameters.AddWithValue("@Title", obj.Title);
                    command.Parameters.AddWithValue("@Input", obj.Input);
                    command.Parameters.AddWithValue("@Content", obj.Content);
                    command.Parameters.AddWithValue("@Date_modified", obj.DateCreated);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
