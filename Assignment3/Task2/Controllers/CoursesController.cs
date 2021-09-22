using System;
using System.Collections.Generic;
using Task2.DBContexts;
using Task2.Entities;

namespace Task2.Controllers
{
    public class CoursesController
    {
        private TrainingContext _context;

        public CoursesController()
        {
            _context = new TrainingContext();
        }

        /*
         * Insert
         */
        public void InsertCourses()
        {
            List<Course> courses = new List<Course>()
            {
                new Course{Title = "C#", Fees = 8000, DurationInHours = 48},
                new Course{Title = "Asp .Net", Fees = 3000, DurationInHours = 96},
                new Course{Title = "Programing Fundamentals", Fees = 5000, DurationInHours = 24},
            };

            foreach (Course course in courses)
            {
                _context.Courses.Add(course);
            }

            _context.SaveChanges();
        }

        /**
         * Update
         */
        public void UpdateCourse(int id, Course crs)
        {
            var course = _context.Courses.Find(id);

            if (!String.IsNullOrEmpty(crs.Title))
                course.Title = crs.Title;

            if (crs.Fees != 0)
                course.Fees = crs.Fees!;

            if (crs.DurationInHours != 0)
                course.DurationInHours = crs.DurationInHours!;


            _context.SaveChanges();
        }

        /**
         * Delete
         */
        public void DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }

        /**
         * Enroll Student
         */
        public void EnrollCourseStudnets(int courseId, List<int> students)
        {
            Course course = _context.Courses.Find(courseId);
            course.Enrollments = new List<Enrollment>();

            foreach (int id in students)
            {
                Student student = _context.Students.Find(id);
                course.Enrollments.Add(new Enrollment { Student = student, EnrollDate = DateTime.Today });
            }

            _context.SaveChanges();
        }
    }
}
