using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    public class Application
    {
        private WelcomeExercise _exercise;
        public Application()
        {
            _exercise = new WelcomeExercise();
            RunExercise();
        }

        private void RunExercise()
        {
            _exercise.VariableCreate();
            _exercise.ArrayCreate();
            _exercise.ColectionCreate();
            _exercise.AddOneToColection(new List<int>{1,2,3});
            _exercise.Split("ala ma kota");
            _exercise.Substring("ala ma kota",3,2);
        }
    }
}
