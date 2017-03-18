using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public TeacherPosition Position { get; set; }
        public ICollection<Community> Communities { get; set; }
    }
}
