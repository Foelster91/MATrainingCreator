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

        private ObservableCollection<Exercise> _exercises;

        private string _name;
        private List<ExerciseCategory> _exerciseCategories;
        private string _description;
        private int _time;
        private bool _isCountable;
        private int _numberOfRepetitions;
        private bool _hasSets;
        private int _numberOfSets;

        #endregion Fields

        #region Bindings

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
            _description = "Get down to the ground. Place your hand below your shoulders ...";
            _time = 12;
            _numberOfRepetitions = 250;
            _numberOfSets = 4;
        }
        #endregion Constructor

    }
}
