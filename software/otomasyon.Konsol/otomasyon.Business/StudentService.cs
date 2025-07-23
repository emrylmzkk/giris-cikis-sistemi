using Otomasyon.Data;


namespace Otomasyon.Business
{
    public class StudentService
    {
        private readonly StudentRepo _studentRepo;
        private readonly LogService _logService;

        public StudentService()
        {
            _studentRepo = new StudentRepo();
            _logService = new LogService();

        }



        public Student? ProcessCardScan(string cardUID)
        {

            

            var student = _studentRepo.GetStudentByCardUID(cardUID);


            if (student != null)
            {
                int newStatus = student.IsInside == 1 ? 0 : 1;

                _studentRepo.UpdateStudentStatus(student.Id, newStatus);


                //Loglama işlemi
                string logType = newStatus == 1 ? "Giriş" : "Çıkış";
                _logService.CreateLogEntry(student.Id, logType);

                student.IsInside = newStatus;


            }

            return student;

        }


        //Yeni ogrenci ekleme

        public void AddNewStudent(Student student)
        {
            _studentRepo.AddStudent(student);
        }


        public int GetCurrentInsideCount()
        {
            return _studentRepo.GetInsideStudentCount();
        }


        public IEnumerable<Student> FindStudentByName(string name)
        {

            var allStudents = _studentRepo.GetLogByName();

            if (string.IsNullOrWhiteSpace(name))
            {
                return allStudents;

            }

            return allStudents.Where(s => s.FullName.Contains(name, StringComparison.CurrentCultureIgnoreCase));



        }

        




    }
}