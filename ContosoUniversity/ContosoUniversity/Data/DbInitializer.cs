using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Ada ",LastName="Chidinma",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Amara",LastName="Ayaan",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2023-09-26")},
                new Student{FirstName="Amara ",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Ada ",LastName="Cleopatra",EnrollmentDate=DateTime.Parse("2023-09-26")},
                new Student{FirstName="PJabari ",LastName="Ayaan",EnrollmentDate=DateTime.Parse("2022-09-26")},
                new Student{FirstName="Amara",LastName="Aberash",EnrollmentDate=DateTime.Parse("2023-09-26")},
                new Student{FirstName="Ada ",LastName="Chidinma",EnrollmentDate=DateTime.Parse("2023-01-26")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="3D Animation",Credits=3},
                new Course{CourseID=4022,Title="3D Art",Credits=3},
                new Course{CourseID=4041,Title="Computing",Credits=3},
                new Course{CourseID=1045,Title="Artificial Intelligence",Credits=4},
                new Course{CourseID=3141,Title="Game Development",Credits=4},
                new Course{CourseID=2021,Title="Computer Science",Credits=3},
                new Course{CourseID=2042,Title="Computer Security",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}