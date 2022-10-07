using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineTrainingTracker.Models;
using System;
using System.Linq;

namespace OnlineTrainingTracker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.EmployeeDetails.Any())
            {
                return;   // DB has been seeded
            }

            var empDetails = new EmployeeDetails[]
            {
                new EmployeeDetails{FirstMidName="Carson",LastName="Alexander",EnrollmentStartDate=DateTime.Parse("2019-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Meredith",LastName="Alonso",EnrollmentStartDate=DateTime.Parse("2017-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Arturo",LastName="Anand",EnrollmentStartDate=DateTime.Parse("2018-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentStartDate=DateTime.Parse("2017-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Yan",LastName="Li",EnrollmentStartDate=DateTime.Parse("2017-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Peggy",LastName="Justice",EnrollmentStartDate=DateTime.Parse("2016-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Laura",LastName="Norman",EnrollmentStartDate=DateTime.Parse("2018-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")},
                new EmployeeDetails{FirstMidName="Nino",LastName="Olivetto",EnrollmentStartDate=DateTime.Parse("2019-09-01"),EnrollmentEndDate=DateTime.Parse("2019-09-01")}
            };

            context.EmployeeDetails.AddRange(empDetails);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Asp .Net",Credits=3},
                new Course{CourseID=4022,Title="AWS",Credits=3},
                new Course{CourseID=4041,Title="Microservice",Credits=3},
                new Course{CourseID=1045,Title="Azure",Credits=4},
                new Course{CourseID=3141,Title="C++",Credits=4},
                new Course{CourseID=2021,Title="Powershell",Credits=3},
                new Course{CourseID=2042,Title="Testing Scripts",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{EmpId=1,CourseID=1050,CompletionStatus=Enrollment.TrainingStatus.Ongoing},
                new Enrollment{EmpId=1,CourseID=4022,CompletionStatus=Enrollment.TrainingStatus.NotStarted},
                new Enrollment{EmpId=1,CourseID=4041,CompletionStatus=Enrollment.TrainingStatus.NotStarted},
                new Enrollment{EmpId=2,CourseID=1045,CompletionStatus=Enrollment.TrainingStatus.Ongoing},
                new Enrollment{EmpId=2,CourseID=3141,CompletionStatus=Enrollment.TrainingStatus.NotStarted},
                new Enrollment{EmpId=2,CourseID=2021,CompletionStatus=Enrollment.TrainingStatus.Ongoing},
                new Enrollment{EmpId=3,CourseID=1050},
                new Enrollment{EmpId=4,CourseID=1050},
                new Enrollment{EmpId=4,CourseID=4022,CompletionStatus=Enrollment.TrainingStatus.Completed},
                new Enrollment{EmpId=5,CourseID=4041,CompletionStatus=Enrollment.TrainingStatus.Completed},
                new Enrollment{EmpId=6,CourseID=1045},
                new Enrollment{EmpId=7,CourseID=3141,CompletionStatus=Enrollment.TrainingStatus.NotStarted},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
