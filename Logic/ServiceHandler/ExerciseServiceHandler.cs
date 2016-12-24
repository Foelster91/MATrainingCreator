using Data.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Data.Models;

namespace Logic.ServiceHandler
{
    public class ExerciseServiceHandler
    {
        public void GetAll()
        {
            ExerciseDatabaseManager.GetAll();
        }

        public ObservableCollection<Exercise> GetAllExercises()
        {
            return ExerciseDatabaseManager.GetAllExercises();
        }

        public List<String> GetNames()
        {
            return ExerciseDatabaseManager.GetNames();
        }
    }
}
