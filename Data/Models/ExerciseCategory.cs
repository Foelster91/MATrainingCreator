using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// The model for the exercise category objects.
    /// </summary>
    public class ExerciseCategory
    {
        #region Properties

        //Every ExerciseCategory has a name
        public String Name { get; set; }

        //An ExerciseCategory might have an discription
        public String Description { get; set; }

        //ExerciseCategories should be arranged in a hierarchy
        //e. g. Karate (Supercategory) -> Kata (Subcategory)
        public ExerciseCategory SuperCategory { get; set; }

        #endregion Properties
    }
}
