using Dapper;
using Microsoft.Data.Sqlite;


namespace Otomasyon.Data
{
    
    public class Database
    {
        private static readonly string _dbFile = "yurt.db";
        private static readonly string _connectionString = $"Data Source= {_dbFile}";

        public static void InitializeDatabase ()
        {

            using (var connection = new SqliteConnection(_connectionString))
            {

                string createStudentTableSql = @"
                    CREATE TABLE IF NOT EXISTS Students(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Surname TEXT NOT NULL,
                        Number TEXT NOT NULL UNIQUE,
                        cardUID TEXT NOT NULL UNIQUE,
                        PhotoPath TEXT,
                        IsInside INTEGER NOT NULL DEFAULT 0,
                        RegistrationDate TEXT NOT NULL
                    
                    )";



                string createLogsTableSql = @"
                   
                CREATE TABLE IF NOT EXISTS Logs (
                Id Integer PRIMARY KEY AUTOINCREMENT,
                StudentId INTEGER NOT NULL,
                LogTime TEXT NOT NULL,
                LogType TEXT NOT NULL,
                FOREIGN KEY (StudentId) REFERENCES Students(Id)
  
            )";


                //Dapper 

                connection.Execute(createStudentTableSql);
                connection.Execute(createLogsTableSql);




    }
            
        }


        public static string GetConnectionString()
        {
            return _connectionString;
        }



    }

}