using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingPartcipate
{
    public class Rank
    {
        public int Serial { get; set; }
        public int Score 
        { get
            {
                throw new NotImplementedException();
            }
        }
        
        public int Penalty
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Member Contestant { get; set; }
        public string Language { get; set; }
        public DateTime Runtime { get; set; }
        public List<RankSubmission> Submissions  { get; set; }
    }
}
