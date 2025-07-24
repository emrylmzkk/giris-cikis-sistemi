using Otomasyon.Data;

namespace Otomasyon.Business
{

    public class LogService
    {
        private readonly LogRepo _logrepo;

        public LogService()
        {
            _logrepo = new LogRepo();

        }

        public void CreateLogEntry(int studentId, string logType)
        {
            var log = new Log
            {
                StudentId = studentId,
                LogType = logType,
                LogTime = DateTime.Now.ToString("HH:mm:ss")
            };

            _logrepo.AddLog(log);

        }

        public IEnumerable<Log> GetRecentLogs()
        {
            return _logrepo.GetRecentLogs();
        }


        public IEnumerable<Log> GetStudentSpecLog(int studentId)
        {
            return _logrepo.GetLogsByID(studentId);
        }


        public void DeleteStudentLogs (int studentId)
        {
            _logrepo.DeleteLogsByStudentId(studentId);
        }


    }



}