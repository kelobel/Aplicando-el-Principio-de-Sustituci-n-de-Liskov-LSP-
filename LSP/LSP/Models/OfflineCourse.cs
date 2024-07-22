using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.LSP.Models
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
        }

        public override string GetCourseDetails()
        {
            return $"Offline Course: {Title} (ID: {CourseId})";
        }
    }
}
