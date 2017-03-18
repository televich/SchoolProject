using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class Lesson
    {
        public int LessonId { get; set; }
        public DateTime Time { get; set; }
        public SchoolTask Task { get; set; }

        public ICollection<Community> Community { get; set; }
        public ICollection<ClassRoom> ClassRoom { get; set; }
        public Teacher Teacher { get; set; }
    }
}
