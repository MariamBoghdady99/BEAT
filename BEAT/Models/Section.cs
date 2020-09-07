using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEAT.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public Director Directors { get; set; }
        public List<Member> Members{ get; set; }
    }
}