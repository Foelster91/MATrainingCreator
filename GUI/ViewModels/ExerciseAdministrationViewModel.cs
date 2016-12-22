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
        private List<string> _exerciseCategories;
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
            _description = "Get down to the ground. Place your hand below your shoulders ...";
            _time = 12;
            _isCountable = true;
            _numberOfRepetitions = 250;
            _hasSets = true;
            _numberOfSets = 4;
        }
        #endregion Constructor

    }
}
