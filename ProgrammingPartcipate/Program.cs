using System;
using System.Collections.Generic;

namespace ProgrammingPartcipate
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranklist = new RankList();
            ranklist.Ranks.Add(new Rank()
            {
                Contestant = new Member(),
                Serial = 1,
                Submissions = new List<RankSubmission>()
            }) ; ;
            ranklist.SortRank();
        }
    }
}
