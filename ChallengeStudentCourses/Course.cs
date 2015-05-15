using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
   {
   public class Course
      {
      public int CourseId { get; set; }
      public string Name { get; set; }
      public List<Student> Students { get; set; }

      public Course()
         {
         this.CourseId = 0;
         this.Name = string.Empty;
         // this.Students = new List<Student>();
         }

      public Course(int courseID, string courseName)
         {
         this.CourseId = courseID;
         this.Name = courseName;
         }

      public string ShowCourseDetails()
         {
         return string.Format("Course: {0} - {1}<br/>", this.CourseId.ToString(), this.Name);
         }
      }
   }
