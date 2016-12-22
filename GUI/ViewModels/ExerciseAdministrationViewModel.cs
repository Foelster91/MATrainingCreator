using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Logic.Models;

namespace GUI.ViewModels
{
    public class ExerciseAdministrationViewModel : ViewModelBase
    {
        #region Fields

        //Fields for the left side of the view
        private ObservableCollection<Exercise> _exercises;

        //Fields for the right side of the view
        private string _name;
        private List<string> _exerciseCategories;
        private string _description;
        private int _time;
        private bool _isCountable;
        private int _numberOfRepetitions;
        private bool _hasSets;
        private int _numberOfSets;

        #endregion Fields

        #region Bindings

        /// <summary>
        /// Binding for the left side of the screen.
        /// </summary>
        public ObservableCollection<Exercise> Exercises
        {
            get
            {
                return _exercises;
            }
            set
            {
                value = _exercises;
            }
        }

        /// <summary>
        /// Binding for the name of an exercise.
        /// </summary>
        public String Name
        {

            get
            {
                return _name;
            }
            set
            {
                value = _name;
            }

        }

        /// <summary>
        /// Binding for the exercise category of an exercise.
        /// </summary>
        public List<string> ExerciseCategories
        {
            get
            {
                return _exerciseCategories;
            }
            set
            {
                value = _exerciseCategories;
            }
        }

        /// <summary>
        /// Binding for the description of an exercise.
        /// </summary>
        public String Description
        {
            get
            {
                return _description;
            }
            set
            {
                value = _description;
            }
        }

        /// <summary>
        /// Binding for the time of an exercise.
        /// </summary>
        public Int32 Time
        {
            get
            {
                return _time;
            }
            set
            {
                value = _time;
            }
        }

        /// <summary>
        /// Binding for the Checkbox for the IsCountable property.
        /// </summary>
        public Boolean IsCountable
        {
            get
            {
                return _isCountable;
            }
            set
            {
                value = _isCountable;
            }
        }

        /// <summary>
        /// Binding for the number of repetitions
        /// </summary>
        public Int32 NumberOfRepetitions
        {
            get
            {
                return _numberOfRepetitions;
            }
            set
            {
                value = _numberOfRepetitions;
            }
        }

        /// <summary>
        /// Binding for the checkbox of the HasSets property
        /// </summary>
        public Boolean HasSets
        {
            get
            {
                return _hasSets;
            }
            set
            {
                value = _hasSets;
            }
        }

        /// <summary>
        /// Binding for the Number of Sets
        /// </summary>
        public Int32 NumberOfSets
        {
            get
            {
                return _numberOfSets;
            }
            set{
                value = _numberOfSets;
            }
        }

        #endregion Bindings

        #region Constructor
        public ExerciseAdministrationViewModel()
        {
            _name = "Push Ups";
            _exerciseCategories = new List<string>();
            _exerciseCategories.Add("Power");
            _description = "Get down to the ground. Place your hands below your shoulders ...";
            _time = 12;
            _isCountable = true;
            _numberOfRepetitions = 250;
            _hasSets = true;
            _numberOfSets = 4;
        }
        #endregion Constructor

    }
}
