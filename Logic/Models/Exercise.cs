using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Exercise
    {
        #region Properties

        //Exercises should have a name
        public String Name { get; set; }

        //Exercises have a description
        public String Description { get; set; }

        //An exercise belongs to an exercise category.
        public ExerciseCategory ExerciseCategory { get; set; }

        //An exercise has a time interval in minutes in which it has to be completed
        public int Time { get; set; }

        //An exercise can be countable or not: e. g. Push-ups are countable, Running is not
        public bool IsCountable { get; set; }

        //An exercise can have an amount of sets, independant from the property iscountable
        //e. g. you can do 4 sets of 25 meter sprints
        public bool HasSets { get; set; }

        #endregion Properties
    }
}
