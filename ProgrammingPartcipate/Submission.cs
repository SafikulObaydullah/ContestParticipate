using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPartcipate
{
    public class Submission
    {
        public ContestProblem Problem { get; set; }
        public SubmissionResult Result { get; set; }
        public DateTime SubmissionTime { get; set; }
    }
}
