using DttLap05Lesson12.Models;
using Microsoft.EntityFrameworkCore;

namespace DttLap05Lesson12.Data
{
    public class DbInitalizer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolContext(
                serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Learners.Any())
                {
                    return;
                }
                var majors = new Major[]
                {
                    new Major{MajorName="Computer Science"},
                    new Major{MajorName="Mathematics"},
                    new Major{MajorName="Physics"},
                    new Major{MajorName="Chemistry"}
                };
                foreach(var m in majors)
                {
                    context.Majors.Add(m);
                }
                context.SaveChanges();
                var learners = new Learner[]
                {
                    new Learner{FirstMidName="John",LastName="Doe",EnrollmentDate=DateTime.Parse("2020-09-01"),MajorID=1},
                    new Learner{FirstMidName="Jane",LastName="Smith",EnrollmentDate=DateTime.Parse("2021-09-01"),MajorID=2},
                    new Learner{FirstMidName="Michael",LastName="Johnson",EnrollmentDate=DateTime.Parse("2022-09-01"),MajorID=3},
                    new Learner{FirstMidName="Emily",LastName="Davis",EnrollmentDate=DateTime.Parse("2023-09-01"),MajorID=4}
                };
                foreach (var l in learners)
                {
                    context.Learners.Add(l);
                }
                context.SaveChanges();
                var courses = new Course[]
                {
                    new Course{CourseID=1050,Title="Chemistry",Credits=3},
                    new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                    new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                };
                foreach (var c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                    new Enrollment{LearnerID=1,CourseID=1050,Grade=5.5f},
                    new Enrollment{LearnerID=1,CourseID=4022,Grade=2.0f},
                    new Enrollment{LearnerID=1,CourseID=4041,Grade=3.0f},
                    new Enrollment{LearnerID=2,CourseID=1050,Grade=3.0f},
                    new Enrollment{LearnerID=2,CourseID=4022,Grade=1.0f},
                    new Enrollment{LearnerID=3,CourseID=4041,Grade=4.0f},
                    new Enrollment{LearnerID=4,CourseID=1050,Grade=2.0f}
                };
                foreach (var e in enrollments)
                {
                    context.Enrollments.Add(e);
                }
                context.SaveChanges();
            }
        }
    }
}