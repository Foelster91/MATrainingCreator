using Data.DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ServiceHandler
{
    public class ExerciseServiceHandler
    {
        public void GetAll()
        {
            ExerciseDatabaseManager.GetAll();
        }

        public void GetNames()
        {
            ExerciseDatabaseManager.GetNames();
        }
    }
}
