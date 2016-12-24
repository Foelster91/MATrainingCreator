using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    /// <summary>
    /// A class that represents an concrete exercise, in which properties such as
    /// the number of sets and repetitions are defined.
    /// </summary>
    public class ExerciseInstance : Exercise
    {
        public int NumberOfRepetitions { get; set; }

        public int NumberOfSets { get; set; }
    }
}
