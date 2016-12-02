using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Fields

        //Field to store the ViewModel displayed on the screen
        private ViewModelBase _currentViewModel;

        #endregion Fields

        #region Bindings

        /// <summary>
        /// Binding that makes the CurrentViewModel to
        /// be displayed accessible by the MainWindow.
        /// </summary>
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }

        /// <summary>
        /// Binding for the 
        /// </summary>
        public RelayCommand<string> NavCommand
        {
            get;
            private set;
        }
        #endregion Bindings

        #region Constructor

        /// <summary>
        /// The constructor creates a new instance of the
        /// current ViewModel.
        /// </summary>
        public MainWindowViewModel()
        {
            //when starting the app set the CurrentViewModel so the screen is not empty
            CurrentViewModel = new MainViewViewModel();
            //initialize the RelayCommand to allow the user to navigate to a different view
            NavCommand = new RelayCommand<string>(Navigate);
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Based on a destination string provided by the view if a click event occurs
        /// this methode navigates to the appropriate view.
        /// </summary>
        /// <param name="destination"></param>
        private void Navigate(string destination)
        {
            switch(destination){
                case "AdministrationExercises":
                    CurrentViewModel = new ExerciseAdministrationViewModel();
                    break;
                case "AdministrationExerciseCategories":
                    CurrentViewModel = new ExerciseCategoryAdministrationViewModel();
                    break;
                case "Information":
                    CurrentViewModel = new InformationViewModel();
                    break;
                default:
                    CurrentViewModel = new MainViewViewModel();
                    break;
            }
        }

        #endregion Methods
    }
}
