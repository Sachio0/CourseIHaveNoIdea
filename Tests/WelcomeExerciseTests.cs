using Course2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class WelcomeExerciseTests
    {
        private WelcomeExercise _welcomeExercise;

        public WelcomeExerciseTests()
        {
            _welcomeExercise = new WelcomeExercise();
        }

        [DataTestMethod]
        [DataRow(typeof(IEnumerable<bool>))]
        //[DataRow(typeof(IEnumerable<int>))]
        //[DataRow(typeof(IEnumerable<double>))]
        //[DataRow(typeof(IEnumerable<char>))]
        //[DataRow(typeof(IEnumerable<string>))]
        public void IsAArrayOfColection_ArrayCreate(Type type)
        {
            Assert.AreEqual(_welcomeExercise.ColectionCreate().GetType(), type);
        }

        [DataTestMethod]
        [DataRow(typeof(bool[]))]
        //[DataRow(typeof(int[]))]
        //[DataRow(typeof(double[]))]
        //[DataRow(typeof(char[]))]
        //[DataRow(typeof(string[]))]
        public void IsAArrayOfType_ArrayCreate(Type type)
        {
            Assert.AreEqual(_welcomeExercise.ArrayCreate().GetType(), type);
        }

        [DataTestMethod]
        [DataRow(typeof(bool))]
        //[DataRow(typeof(int))]
        //[DataRow(typeof(double))]
        //[DataRow(typeof(char))]
        //[DataRow(typeof(string))]
        public void IsAType_VariableCreate(Type type)
        {
            Assert.AreEqual(_welcomeExercise.VariableCreate().GetType(), type);
        }

        [DataTestMethod]
        [DynamicData(nameof(AddOneData), DynamicDataSourceType.Method)]
        public void IsCorrectAdded_AddOneToColection(List<int> input, List<int> expected)
        {
            CollectionAssert.AreEqual(expected, _welcomeExercise.AddOneToColection(input));
        }

        [DataTestMethod]
        [DataRow("ala ma kota", 3)]
        public void SplitTest(string input, int count)
        {
            Assert.AreEqual(count, _welcomeExercise.Split(input).Length);
        }

        [DataTestMethod]
        [DataRow("ala ma kota", 4, 2, "ma")]
        public void SubstringTest(string input, int startIndex, int lenght, string expected)
        {
            Assert.AreEqual(expected, _welcomeExercise.Substring(input, startIndex, lenght));
        }

        private static IEnumerable<object[]> AddOneData()
        {
            yield return new object[] { new List<int> { 1, 2, 3 }, new List<int> { 2, 3, 4 } };
            yield return new object[] { new List<int> { -1, -1, -1 }, new List<int> { 0, 0, 0 } };
        }
    }
}