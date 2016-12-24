using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Logic.ServiceHandler;

namespace GUI.ViewModels
{
    public class ExerciseAdministrationViewModel : ViewModelBase
    {
        #region Fields

        //Fields for the left side of the view
        //private ObservableCollection<Exercise> _exercises;

        //Fields for the right side of the view
        private string _name;
        private List<string> _exerciseCategories;
        private string _selectedExerciseCategory;
        private string _description;
        private int _time;
        private bool _isCountable;
        private int _numberOfRepetitions;
        private bool _hasSets;
        private int _numberOfSets;

        private RelayCommand _saveCommand;

        private ExerciseServiceHandler _esh;

        #endregion Fields

        #region Bindings

        /// <summary>
        /// Binding for the left side of the screen.
        /// </summary>
        //public ObservableCollection<Exercise> Exercises
        //{
        //    get
        //    {
        //        return _exercises;
        //    }
            
        //}

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
                _name = value;
                OnPropertyChanged("Name");
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

        }

        /// <summary>
        /// Binding for the selected exercise category
        /// </summary>
        public String SelectedExerciseCategory
        {
            
            get
            {             
                return _selectedExerciseCategory;;
            }
            set
            {
                _selectedExerciseCategory = value;
                OnPropertyChanged("SelectedExerciseCategory");
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
                _description = value;
                OnPropertyChanged("Description");
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
                _time = value;
                OnPropertyChanged("Time");
            }
        }

        /// <summary>
        /// Binding for the checkbox for the IsCountable property.
        /// </summary>
        public Boolean IsCountable
        {
            get
            {
                return _isCountable;
            }
            set
            {
                _isCountable = value;
                OnPropertyChanged("IsCountable");
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
                _numberOfRepetitions = value;
                OnPropertyChanged("NumberOfRepetitions");
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
                _hasSets = value;
                OnPropertyChanged("HasSets");
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
            set
            {
                _numberOfSets = value;
                OnPropertyChanged("NumberOfSets");
            }
        }

        #endregion Bindings

        #region Commands

        /// <summary>
        /// Binding for the SaveCommand
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(param => this.Save());
                }
                return _saveCommand;
            }
        }

        #endregion Commands

        #region Constructor
        /// <summary>
        /// Constructor for the ExerciseAdministrationViewModel
        /// </summary>
        public ExerciseAdministrationViewModel()
        {
            ExerciseServiceHandler esh = new ExerciseServiceHandler();
            _esh = esh;

            LoadExercises();
            LoadExerciseCategories();
        }
        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method to save changes to an exercise
        /// </summary>
        private void Save()
        {
            //check if all the necessary data has been entered by the user to change or add an exercise
            if(_name == null || _selectedExerciseCategory == null || _description == null)
            {
                //notify the user that data is missing
                //just return for now
                return;
            }
        }

        /// <summary>
        /// Method to load the exercise categories
        /// </summary>
        private void LoadExerciseCategories()
        {
            _exerciseCategories = new List<string>();
            _exerciseCategories.Add("Power");
        }

        /// <summary>
        /// Method to load the exercises into the datagrid
        /// </summary>
        private void LoadExercises()
        {
            _esh.GetAll();
            _esh.GetNames();
        }

        #endregion Methods
    }
}
