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
        public SchoolTask Task { get; set; } 
        
        /// <summary>
        /// надо что то придумать с временем урока 
        /// потому что неудобно с датами а время
        /// а время урока все время одинаковое
        /// надо будет добавить что то типо временного промежутка (1-ый, 2-ой урок) 
        /// </summary>
        
        public DateTime startLesson { get; set; }
        public DateTime endLesson { get; set; }

        public int CommunityId { get; set; }
        public Community Community { get; set; }
        public int ClassRoomId { get; set; }
        ClassRoom ClassRoom { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Journal> Journals { get; set; }
    }
}