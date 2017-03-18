using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public string Number { get; set; }

        public Lesson Lesson { get; set; }
    }
}
