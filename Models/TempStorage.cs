using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection.Models
{
    //A model that temporarily stores the information submitted on the website
    public class TempStorage
    {
        private static List<Submissions> submissions = new List<Submissions>();

        public static IEnumerable<Submissions> Submissions => submissions;

        public static void AddMovie(Submissions submission)
        {
            submissions.Add(submission);
        }
    }
}
