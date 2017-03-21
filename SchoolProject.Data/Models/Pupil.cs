﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Models
{
    class Pupil
    {
        public int PupilId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CommunityId { get; set; }
        public Community Community { get; set; }
        public ICollection<Journal> Journals { get; set; }
    }
}
