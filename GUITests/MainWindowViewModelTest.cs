using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI.ViewModels;

namespace GUITests
{
    [TestClass]
    public class MainWindowViewModelTest
    {
        #region Navigate-Method
        [TestMethod]
        public void NavigateTestInputStringIsNull()
        {
            //Arrange
            var mainwindowvm = new MainWindowViewModel();
            var adminexercisevm = new ExerciseAdministrationViewModel();
            string navigateto = null;

            //Act
            mainwindowvm.Navigate(navigateto);

            //Assert
            Assert.IsNotNull(mainwindowvm.CurrentViewModel);

        }

        [TestMethod]
        public void NavigateTestInputStringIsEmpty()
        {
            //Arrange
            var mainwindowvm = new MainWindowViewModel();
            var adminexercisevm = new ExerciseAdministrationViewModel();
            string navigateto = "";

            //Act
            mainwindowvm.Navigate(navigateto);

            //Assert
            Assert.IsNotNull(mainwindowvm.CurrentViewModel);

        }

        [TestMethod]
        public void NavigateTestToExerciseAdministration()
        {
            ////Arrange
            //var mainwindowvm = new MainWindowViewModel();
            //var adminexercisevm = new ExerciseAdministrationViewModel();
            //var navigateto = "AdministrationExercises";

            ////Act
            //mainwindowvm.Navigate(navigateto);

            ////Assert
            //Assert.IsInstanceOfType(mainwindowvm.CurrentViewModel, adminexercisevm);

        }
        #endregion Navigate-Method
    }
}
