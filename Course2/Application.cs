using System.Collections.Generic;
using System.Configuration;

namespace Course2
{
    public class Application
    {
        private WelcomeExercise _exercise;

        public Application()
        {
            _exercise = new WelcomeExercise();
            GetConfiguration();
            RunExercise();
        }

        private void GetConfiguration()
        {
            var sth = ConfigurationManager.AppSettings["Name"];
        }

        private void RunExercise()
        {
            _exercise.VariableCreate();
            _exercise.ArrayCreate();
            _exercise.ColectionCreate();
            _exercise.AddOneToColection(new List<int> { 1, 2, 3 });
            _exercise.Split("ala ma kota");
            _exercise.Substring("ala ma kota", 3, 2);
        }
    }
}