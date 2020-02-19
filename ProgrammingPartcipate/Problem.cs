using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPartcipate
{
    public class Problem : Description
    {
        public string ProblemNumber { get; set; }
        public string Title { get; set; }
        public Category category { get; set; }
        public Description descriptions  { get; set; }
    }
}
