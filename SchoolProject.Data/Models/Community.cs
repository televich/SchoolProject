using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class Community
    {
        public int CommunityId { get; set; }
        public string Letter { get; set; }
        public short Number { get; set; }
        public ICollection<Pupil> Pupils { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Lesson Lesson { get; set; }
    }
}
