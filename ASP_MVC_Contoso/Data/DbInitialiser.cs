using ASP_MVC_Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Contoso.Data
{
    public class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Kayley",LastName="Syrett",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="April",LastName="Syrett",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Andrew",LastName="Syrett",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Helen",LastName="Wood",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Alex",LastName="Wood",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Amy",LastName="Wood",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Lilly",LastName="Wood",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Alfie",LastName="Syrett",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Database Design",Credits=3},
                new Course{CourseID=4022,Title="Networking",Credits=3},
                new Course{CourseID=4041,Title="Advanced Programming",Credits=3},
                new Course{CourseID=1045,Title="Mobile Systems",Credits=4},
                new Course{CourseID=3141,Title="Web Applications",Credits=4},
                new Course{CourseID=2021,Title="User Experience",Credits=3},
                new Course{CourseID=2042,Title="Cyber Security",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
