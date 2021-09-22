using System;
using System.Collections.Generic;
using Task2.DBContexts;
using Task2.Entities;

namespace Task2.Controllers
{
    public class StudentsController
    {
        private TrainingContext _context;

        public StudentsController()
        {
            _context = new TrainingContext();
        }

        /*
         * Insert
         */
        public void InsertStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Name = "Peter", DateOfBirth = new DateTime(1991, 02, 01), Address="India"},
                new Student{Name = "John", DateOfBirth = new DateTime(1990, 05, 01), Address="Dhaka"},
                new Student{Name = "Rio", DateOfBirth = new DateTime(1996, 03, 01), Address="Sylhet"},
                new Student{Name = "Robert", DateOfBirth = new DateTime(1989, 02, 01), Address="Dhaka"},
                new Student{Name = "Andre", DateOfBirth = new DateTime(1991, 02, 01), Address="Cumilla"},
            };

            foreach (Student student in students)
            {
                _context.Students.Add(student);
            }

            _context.SaveChanges();
        }

        /*
         * Update
         */
        public void UpdateStudent(int id, Student std)
        {
            var student = _context.Students.Find(id);

            if (!String.IsNullOrEmpty(std.Name))
                student.Name = std.Name;

            if (!String.IsNullOrEmpty(std.Address))
                student.Address = std.Address!;

            if (std.DateOfBirth != DateTime.MinValue)
                student.DateOfBirth = std.DateOfBirth!;


            _context.SaveChanges();
        }


        /**
         *Delete
         */
        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
