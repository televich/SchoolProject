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
        public short Mark { get; set; }

        public ICollection<Pupil> Pupil { get; set; }
        public ICollection<Lesson> Lesson { get; set; }
    }
}
