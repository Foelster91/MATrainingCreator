using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class TrainingSession
    {
        #region Properties

        //Every training session has a name
        public String Name { get; set; }

        //Every training session should have a short description with goal specification
        public String Description { get; set; }

        //A training session might be created for a specific date
        public DateTime Date { get; set; }

        //Every training session has a time measured in minutes
        public int Time { get; set; }

        //Every training session has a set of exercises
        public ObservableCollection<Exercise> Exercises { get; set; }

        #endregion Properties
    }
}
