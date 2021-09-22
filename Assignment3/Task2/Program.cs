using System;
using Task2.Controllers;
using Task2.Entities;
using System.Collections.Generic;
using Task2.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsController student = new StudentsController();
            //student.InsertStudents();
            //student.UpdateStudent(2, new Student { Name = "Nirobi", Address = "Japan" });
            //student.DeleteStudent(3);

            CoursesController course = new CoursesController();
            //course.InsertCourses();
            //course.UpdateCourse(2, new Course { Fees = 30000 });
            //course.DeleteCourse(3);

            //course.EnrollCourseStudnets(1, new List<int> { 1, 2, 4});
            //course.EnrollCourseStudnets(2, new List<int> { 2, 4 });

            TrainingContext context = new TrainingContext();

            var courses = context.Courses.Include(e => e.Enrollments).ThenInclude(s => s.Student);

            //foreach(var crs in courses)
            //{
            //    Console.WriteLine($"Course Title: {crs.Title} , Fees: {crs.Fees}");

            //    foreach(var std in crs.Enrollments)
            //    {
            //        Console.WriteLine($"Student Name: {std.Student.Name}");
            //    }

            //    Console.WriteLine();
            //}


            var students = context.Students.Include(e => e.Enrollments).ThenInclude(c => c.Course);

            //foreach(var std in students)
            //{
            //    Console.WriteLine($"Student Name: {std.Name}");

            //    foreach(var crs in std.Enrollments)
            //    {
            //        Console.WriteLine($"Course Title: {crs.Course.Title}");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
