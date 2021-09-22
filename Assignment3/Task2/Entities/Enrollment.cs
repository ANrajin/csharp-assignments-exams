using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CoureId { get; set; }
        public Course course { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}
