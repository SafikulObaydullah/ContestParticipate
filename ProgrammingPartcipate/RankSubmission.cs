using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingPartcipate
{
    public class RankSubmission 
    {
        public ContestProblem problem  { get; set; }
        List<Submission> submissions { get; set; }
        public int FailedAttempt
        {
            get
            {
                return submissions.Where(x => x.Result!= SubmissionResult.Accepted).Count();
            }
        }
        public int GetPenalty(DateTime contestStartTime)
        {
            var successfulAttempt = submissions.Where(x => x.Result == SubmissionResult.Accepted).FirstOrDefault();
            return FailedAttempt + 20 + (int)successfulAttempt.SubmissionTime.Subtract(contestStartTime).TotalMinutes;
        }
        
    }
}
