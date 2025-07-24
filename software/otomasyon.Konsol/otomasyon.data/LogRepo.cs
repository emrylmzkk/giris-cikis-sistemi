using Dapper;
using Microsoft.Data.Sqlite;
using System.Runtime.InteropServices.Marshalling;


namespace Otomasyon.Data
{

    public class LogRepo
    {
        public void AddLog(Log log)
        {
            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {

                string sql = @"INSERT INTO Logs (StudentId, LogTime, LogType) VALUES (@StudentId, @LogTime, @LogType)";


                connection.Execute(sql, log);



            }
        }

        public IEnumerable<Log> GetRecentLogs(int limit =20)
        {
            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {
                string sql = @"SELECT L.LogTime, L.LogType, S.Name || ' ' || S.Surname AS StudentFullName FROM Logs L JOIN Students S ON L.StudentId = S.Id ORDER BY L.Id DESC LIMIT @Limit;";

                return connection.Query<Log>(sql, new { Limit = limit });
            }
        }

        public IEnumerable<Log> GetLogsByID(int studentId)
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {

                string sql = @"SELECT LogTime, LogType FROM Logs WHERE StudentId = @StudentId ORDER BY Id DESC";


                return connection.Query<Log>(sql, new {StudentId = studentId });
                


            }


        }


        public void DeleteLogsByStudentId(int studentId)
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {

                string sql = "DELETE FROM Logs WHERE StudentId = @StudentId";

                connection.Execute(sql, new { StudentId = studentId });

            }


        }


    }


}