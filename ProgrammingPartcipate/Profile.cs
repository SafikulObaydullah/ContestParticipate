using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPartcipate
{
    public class Profile
    {
        public string Country { get; set; }
        public string UniversityName { get; set; }
        public int Solved { get; set; }
        public int Tried { get; set; }
        public Submission submissions
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
