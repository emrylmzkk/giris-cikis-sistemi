using Dapper;
using Microsoft.Data.Sqlite;
using Otomasyon.Data;



namespace Otomasyon.Data
{
    public class StudentRepo
    {
        public Student? GetStudentByCardUID(string cardUID)
        {
            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {
                string sql = "SELECT * FROM Students WHERE CardUID = @CardUID";



                var student = connection.QueryFirstOrDefault<Student>(sql, new { CardUID = cardUID });


                return student;
            }


        }

        public void AddStudent(Student student)
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {


                string sql = @"
                INSERT INTO Students (Name, Surname, Number, cardUID, PhotoPath, IsInside, RegistrationDate)
                VALUES (@Name, @Surname, @Number, @cardUID, @PhotoPath, @IsInside, @RegistrationDate);

                ";

                connection.Execute(sql, student);
            }



        }


        public void UpdateStudentStatus(int studentId, int status)
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {
                string sql = "UPDATE Students SET IsInside = @Status WHERE Id = @Id";

                connection.Execute(sql, new { Status = status, Id = studentId });
            }

        }


        public int GetInsideStudentCount()
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString())) {

                string sql = "SELECT COUNT (*) FROM Students WHERE IsInside = 1";

                int count = connection.ExecuteScalar<int>(sql);


                return count;




            }


        }


        public IEnumerable<Student> GetLogByName()
        {

            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {


                string sql = @"SELECT Id, Name, Surname FROM Students";



                return connection.Query<Student>(sql);


            }

        }



        public void DeleteStudentById(int studentId)
        {
            using (var connection = new SqliteConnection(Database.GetConnectionString()))
            {
                string sql = "DELETE FROM Students WHERE Id = @Id";
                connection.Execute(sql, new { Id = studentId });
            }


        }




    }
}