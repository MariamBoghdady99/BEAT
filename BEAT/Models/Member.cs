using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEAT.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentLevel { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}