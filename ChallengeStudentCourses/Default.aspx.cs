using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
   {
   public partial class Default : System.Web.UI.Page
      {
      protected void Page_Load(object sender, EventArgs e)
         {
         

         }

      protected void assignment1Button_Click(object sender, EventArgs e)
         {
         /*
          * Create a List of Courses (add three example Courses ...
          * make up the details).  Each Course should have at least two
          * Students enrolled in them.  Use Object and Collection
          * Initializers.  Then, iterate through each Course and print
          * out the Course's details and the Students that are enrolled in
          * each Course.
          */



         //Car car1 = new Car("BMW", "528i", 2010, "Black");
         //Car car2 = new Car("BMW", "745li", 2005, "Black");
         //Car car3 = new Car("Ford", "Escape", 2008, "White");

         //List<Car> cars = new List<Car>();

         //cars.Add(car1);
         //cars.Add(car2);
         //cars.Add(car3);

         ////List<Car> whiteCars = cars.FindAll(p => p.Color == "White");
         ////cars.ForEach(p => p.Color = "Silver");
         ////if (cars.Exists(p => p.Year == 2008))
         ////    result += "We do have a 2008 model year in stock!";

         //for (int i = 0; i < cars.Count; i++)
         //   {
         //   result += cars.ElementAt(i).FormatDetailsForDisplay();
         //   }


         //resultLabel.Text = result;

         Course course1 = new Course(1, "Spanish");
         Course course2 = new Course(2, "Math");
         Course course3 = new Course(3, "Science");

         List<Course> courses = new List<Course>();
         courses.Add(course1);
         courses.Add(course2);
         courses.Add(course3);

         string result = string.Empty;

         for(int c=0;c < courses.Count; c++)
            {
              result+= courses.ElementAt(c).ShowCourseDetails();
            }

            resultLabel.Text=result;
         }

      protected void assignment2Button_Click(object sender, EventArgs e)
         {
         /*
          * Create a Dictionary of Students (add three example Students
          * ... make up the details).  Use the StudentId as the 
          * key.  Each student must be enrolled in two Courses.  Use
          * Object and Collection Initializers.  Then, iterate through
          * each student and print out to the web page each Student's
          * info and the Courses the Student is enrolled in.
          */


         }

      protected void assignment3Button_Click(object sender, EventArgs e)
         {
         /*
          * We need to keep track of each Student's grade (0 to 100) in a 
          * particular Course.  This means at a minimum, you'll need to add 
          * another class, and depending on your implementation, you will 
          * probably need to modify the existing classes to accommodate this 
          * new requirement.  Give each Student a grade in each Course they
          * are enrolled in (make up the data).  Then, for each student, 
          * print out each Course they are enrolled in and their grade.
          */


         }
      }
   }