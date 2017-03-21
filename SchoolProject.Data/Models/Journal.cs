using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class Journal
    {
        public int JournalId { get; set; }
        public byte Mark { get; set; }
        public int PupilId { get; set; }
        public Pupil Pupil { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
