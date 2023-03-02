using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class RegisteredSubject
    {
        public string StudentId { get; set; }
        public string SubjectName { get; set; }
        public DateTime RegisterTime { get; set; }
        public RegisteredSubject(string studentId,
            string subjectName, DateTime reg)
        {
            StudentId = studentId;
            SubjectName = subjectName;
            RegisterTime = reg;
        }
    }
}
