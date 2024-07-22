using System;


namespace LSP.LSP.Models
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            
        }

        public override string GetCourseDetails()
        {
            return $"Online Course: {Title} (ID: {CourseId})";
        }
    }
}
